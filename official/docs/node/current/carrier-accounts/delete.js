const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const carrierAccount = await client.CarrierAccount.retrieve('ca_...');

  await client.CarrierAccount.delete(carrierAccount.id);
})();
