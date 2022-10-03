using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            EasyPost.ClientManager.SetCurrent(apiKey);

            EventCollection events = await Event.All(new Dictionary<string, object>
            {
                { "page_size", 5 }
            });

            Console.WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
        }
    }
}