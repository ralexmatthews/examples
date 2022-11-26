using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Dictionary<string, object> addressData = new Dictionary<string, object>() {
  { "company", "EasyPost" },
  { "street1", "417 Montgomery Street" },
  { "street2": "5th Floor" },
  { "city", "San Francisco" },
  { "state", "CA" },
  { "zip", "94104" },
  { "phone", "415-528-7555" }
};

Address fromAddress = await Address.Create(addressData);
