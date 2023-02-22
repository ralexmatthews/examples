using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Shipment shipment = await client.Shipment.Create(new Dictionary<string, object>()
                {
                    {
                        "to_address", new Dictionary<string, object>()
                        {
                            { "name", "Dr. Steve Brule" },
                            { "street1", "179 N Harbor Dr" },
                            { "city", "Redondo Beach" },
                            { "state", "CA" },
                            { "zip", "90277" },
                            { "country", "US" },
                            { "phone", "8573875756" },
                            { "email", "dr_steve_brule@gmail.com" }
                        }
                    },
                    {
                        "from_address", new Dictionary<string, object>()
                        {
                            { "name", "EasyPost" },
                            { "street1", "417 Montgomery Street" },
                            { "street2", "5th Floor" },
                            { "city", "San Francisco" },
                            { "state", "CA" },
                            { "zip", "94104" },
                            { "country", "US" },
                            { "phone", "4153334445" },
                            { "email", "support@easypost.com" }
                        }
                    },
                    {
                        "parcel", new Dictionary<string, object>()
                        {
                            { "length", 20.2 },
                            { "width", 10.9 },
                            { "height", 5 },
                            { "weight", 65.9 }
                        }
                    }
                });

            List<StatelessRate> rates = await client.Beta.Rate.RetrieveStatelessRates(shipment);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
