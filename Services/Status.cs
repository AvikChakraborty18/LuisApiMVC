using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ADBot.Services
{
    public class Status
    {
        public async static Task<string> ApiCall()
        {
            var client = new System.Net.Http.HttpClient();


            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "8e58705e846746929c09bde10ef6844f");

            var uri = "https://westus.api.cognitive.microsoft.com/luis/api/v2.0/apps/7f7a0d7e-842b-4cdc-bb8e-e51e12b081f4/versions/0.2/train?";

            var response = await client.GetAsync(uri);
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}