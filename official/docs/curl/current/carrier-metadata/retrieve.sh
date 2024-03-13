# Request all metadata for all carriers
curl -X GET https://api.easypost.com/v2/metadata/carriers \
  -u "EASYPOST_API_KEY":

# Request specific metadata for specific carriers
curl -X GET "https://api.easypost.com/v2/metadata/carriers?carriers=usps&types=service_levels,predefined_packages" \
  -u "EASYPOST_API_KEY":
