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

            var client = EasyPost.Client(apiKey);

            Dictionary<string, object> listParams = new Dictionary<string, object>()
            {
                { "page_size", 5 }
            };

            ShipmentCollection shipmentCollection = await client.Shipment.All(listParams);

            Console.WriteLine(JsonConvert.SerializeObject(shipmentCollection, Formatting.Indented));
        }
    }
}
