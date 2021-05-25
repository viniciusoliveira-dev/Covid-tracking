using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Domain
{
    public class Teste
    {
        public System.Threading.Tasks.Task<string> testeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-tracking.p.rapidapi.com/v1"),
                Headers =
                {
                    { "x-rapidapi-key", "f39163a60cmsh5dbbe815ab8b2bbp169ce1jsn363ad8afacf9" },
                    { "x-rapidapi-host", "covid-19-tracking.p.rapidapi.com" },
                },
            };

            var response = client.SendAsync(request).Result;
            var teste = response.Content.ReadAsStringAsync();
            return teste;
            // using (var response = await client.SendAsync(request))
            // {
            //     response.EnsureSuccessStatusCode();
            //     var body = await response.Content.ReadAsStringAsync();
            //     return body;
            // }
        }
    }
}