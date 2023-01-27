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

            Payload payload = await Client.Event.RetrievePayload("evt_...", "payload_...");

            Console.WriteLine(JsonConvert.SerializeObject(payload, Formatting.Indented));
        }
    }
}
