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

            Order order = await Order.Create(new Dictionary<string, object>()
            {
                {
                    "to_address", new Dictionary<string, string>()
                    {
                        { "id", "adr_..." }
                    }
                },
                {
                    "from_address", new Dictionary<string, string>()
                    {
                        { "id", "adr_..." }
                    }
                },
                {
                    "shipments", new List<Dictionary<string, object>>()
                    {
                        {
                            new Dictionary<string, object>
                            {
                                {
                                    "parcel", new Dictionary<string, object>()
                                    {
                                        { "weight", 10.2 }
                                    }
                                }
                            }
                        },
                        {
                            new Dictionary<string, object>
                            {
                                {
                                    "parcel", new Dictionary<string, object>()
                                    {
                                        { "predefined_package", "FedExBox" },
                                        { "weight", 17.5 }
                                    }
                                }
                            }
                        }
                    }
                },
                { "service", "NextDayAir" },
                {
                    "carrier_accounts", new List<string>()
                    {
                        "ca_..."
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
