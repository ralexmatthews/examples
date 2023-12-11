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

            string referralUserApiKey = Environment.GetEnvironmentVariable("REFERRAL_USER_API_KEY")!;

            PaymentMethod paymentMethod = await client.ReferralCustomer.AddCreditCardToUser(referralUserApiKey, "0123456789101234", "01", "2025", "111", PaymentMethod.Priority.Primary);

            Console.WriteLine(JsonConvert.SerializeObject(referralUser, Formatting.Indented));
        }
    }
}
