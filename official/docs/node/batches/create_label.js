const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const batch = api.Batch.retrieve('batch_...').then((b) => {
  b.generateLabel('PDF').then(console.log);
});
