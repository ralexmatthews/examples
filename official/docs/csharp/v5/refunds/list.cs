using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Parameters.Refund.All parameters = new()
            {
                PageSize = 5
            };

            RefundCollection refundCollection = await client.Refund.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refundCollection, Formatting.Indented));
        }
    }
}
