using ADBot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ADBot.Services
{
    public class Publish
    {
        public async static Task<string> ApiCall()
        {
            var client = new HttpClient();
            PublishConfig publishConfig = new PublishConfig();

            var body = JsonConvert.SerializeObject(publishConfig);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "8e58705e846746929c09bde10ef6844f");

            var uri = "https://westus.api.cognitive.microsoft.com/luis/api/v2.0/apps/7f7a0d7e-842b-4cdc-bb8e-e51e12b081f4/publish?";

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes(body);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
    }
}