curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "DaiPostAccount",
  "description": "DaiPostAccount",
  "carrier_account": {
    "credentials": {
      "account_code": "VALUE",
      "origin_terminal": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
