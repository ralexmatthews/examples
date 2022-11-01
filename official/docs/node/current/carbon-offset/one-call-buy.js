const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

/* Either objects or ids can be passed in. If the object does
 * not have an id, it will be created. */

const toAddress = new api.Address({ ... });
const fromAddress = new api.Address({ ... });
const parcel = new api.Parcel({ ... });
const customsInfo = new api.CustomsInfo({ ... });

const shipment = new api.Shipment({
  carrier_accounts: ["ca_..."],
  service: "NextDayAir",
  to_address: toAddress,
  from_address: fromAddress,
  parcel: parcel,
  customs_info: customsInfo
});

// Enable carbon offset by passing `true` to the `save()` function
shipment.save(true).then(console.log);
