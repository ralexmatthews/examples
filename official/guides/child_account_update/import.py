# This script will import and update USPS credentials for all child accounts from a CSV file

# NOTE: Due to the nature of the easypost API library,
# this script will run synchronously and therefore may take a while to complete if you have a lot of child accounts

from typing import List, Dict, Union

import easypost
import argparse
import csv

parser = argparse.ArgumentParser(description="Import all child account USPS production credentials")
parser.add_argument("-k", "--key", required=True, help="Parent production API key")


def authenticate(key: str):
    """
    Authenticate with the given API key

    :param key: API key to authenticate with
    :type key: str
    :raises ValueError: If the key is invalid
    :return: None
    """
    if not key:
        raise ValueError("API key not provided")
    easypost.api_key = key


def get_production_key(keys: List) -> Union[str, None]:
    """
    Get the production key from a list of keys

    :param keys: List of keys
    :type keys: List
    :return: Production key if found, None otherwise
    :rtype: str | None
    """
    for key in keys:
        if key["mode"] == "production":
            return key["key"]
    return None


def process_entry(entry: Dict, child: easypost.User):
    """
    Process a single entry from the CSV file

    :param entry: Entry from the CSV file
    :type entry: Dict
    :param child: Child account object
    :type child: easypost.User
    :return: None
    """
    child_prod_key = get_production_key(child.keys)
    authenticate(child_prod_key)

    account: easypost.CarrierAccount = easypost.CarrierAccount.retrieve(easypost_id=entry["ca_id"])
    if not account:
        print("Matching account not found for ID {}".format(entry["ca_id"]))
        return

    if entry["credential_type"] == "test":
        account.test_credentials = entry["credentials"]
    elif entry["credential_type"] == "prod":
        account.prod_credentials = entry["credentials"]
    print(account)
    # account.save()  # TODO: Uncomment this line to actually save the changes


def read_from_csv() -> List[Dict]:
    """
    Read and validate data from the CSV file

    :return: List of valid entries from the CSV file
    :rtype: List[Dict]
    """
    with open("child_accounts.csv", "r") as csvfile:
        reader = csv.DictReader(csvfile)
        data = []
        for row in reader:
            entry = {
                "child_id": row["child_id"],
                "ca_id": row["ca_id"],
                "credential_type": row["credential_type"],
                "credentials": {
                    "address_city": row["city"],
                    "address_state": row["state"],
                    "address_street": row["street"],
                    "address_zip": row["zip"],
                    "company_name": row["company"],
                    "email": row["email"],
                    "phone": row["phone"],
                    "shipper_id": row["shipper_id"],
                },
            }
            if validate_entry(entry):
                data.append(entry)
        return data


def validate_entry(row: Dict) -> bool:
    """
    Validate a row entry from the CSV file

    :param row: Data from the CSV file
    :type row: Dict
    :raises Exception: If the entry is invalid
    :return: True if the row is valid, False otherwise
    :rtype: bool
    """
    for k, v in row["credentials"].items():
        if k in ["shipper_id"]:  # These are optional fields that can be empty
            continue
        if not v or v == "":
            raise Exception(f'Missing required field {k} for carrier account {row["ca_id"]}')
    return True


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    authenticate(args.key)

    user = easypost.User.retrieve_me()
    all_children: List[easypost.User] = user.all_api_keys().children

    csv_data = read_from_csv()
    for entry in csv_data:
        matching_child = None
        for child in all_children:
            if child.id == entry["child_id"]:
                matching_child = child
                break
        if not matching_child:
            print("Matching child account not found for ID {}".format(entry["child_id"]))
            continue
        process_entry(entry, matching_child)


if __name__ == "__main__":
    main()
