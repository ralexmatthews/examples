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

            CarrierAccount carrierAccount = await client.CarrierAccount.Create(new Dictionary<string, object>()
            {
                { "type", "UpsAccount" },
                { "description", "NY Location UPS Account" },
                { "reference", "my-reference" },
                {
                    "credentials", new Dictionary<string, object>
                    {
                        { "account_number", "A1A1A1" },
                        { "user_id", "USERID" },
                        { "password", "PASSWORD" },
                        { "access_license_number", "ALN" }
                    }
                },
                {
                    "test_credentials", new Dictionary<string, object>
                    {
                        { "account_number", "A1A1A1" },
                        { "user_id", "USERID" },
                        { "password", "PASSWORD" },
                        { "access_license_number", "ALN" }
                    }
                },
            });

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}