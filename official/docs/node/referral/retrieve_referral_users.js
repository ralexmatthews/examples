const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_PRODUCTION_API_KEY>');

api.Referral.all({
  page_size: 5,
}).then(console.log);