using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples;

public class Examples
{
    [Fact]
    public async Task CreateVerifiedAddress()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Address address = await Address.Create(
            new Dictionary<string, object>
            {
                {
                    "street1", "417 Montgomery Street"
                },
                {
                    "street2", "5"
                },
                {
                    "city", "San Francisco"
                },
                {
                    "state", "CA"
                },
                {
                    "zip", "94104"
                },
                {
                    "country", "US"
                },
                {
                    "company", "EasyPost"
                },
                {
                    "phone", "415-123-4567"
                },
                {
                    "verify", true
                }
            }
        );

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
    }
}
