const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const scanForm = await client.ScanForm.retrieve('sf_...');

  console.log(scanForm);
})();
