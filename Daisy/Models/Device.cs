using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Daisy.Models
{
    public static class Device
    {
        public static string Name { get; set; }
        public static string Url = "https://daisy.is-super.moe/";

        public static async Task<string> GetDevice()
        {
            var client = new HttpClient();
            //Add the header as a key value pair
            client.DefaultRequestHeaders.Add("9d7996b5-5dcc-454a-b538-7b8de4e9f9df", "X-DAISY_FLOWER_SECRET");

            var response = await client.GetStringAsync("https://daisy.is-super.moe/api/v1/devices");

            Name = response;
            return response;
        }
    }
}
