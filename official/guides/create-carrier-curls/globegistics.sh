curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "GlobegisticsAccount",
  "description": "GlobegisticsAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "facility": "VALUE"
    }
  }
}'
