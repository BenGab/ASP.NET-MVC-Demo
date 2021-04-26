using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AspClient
{
    public class PatientApiClient
    {
        private Func<HttpClient> httpClientfactory;
        private const string url = "http://localhost:3314/api/patient";

        public PatientApiClient()
        {
            httpClientfactory = () => new HttpClient();
        }

        public async Task<IEnumerable<PatientViewModel>> GetPatients()
        {
            using (var httpClient = httpClientfactory())
            {
                var response = await httpClient.GetAsync(url).ConfigureAwait(false);
                string body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<PatientViewModel>>(body);
                return result;
            }
        }

        public async Task PostModel()
        {
            using (var httpclient = httpClientfactory())
            {
                var newMOdel = new PatientViewModel()
                {
                    Address = "wdadsaaa",
                    Email = "sadsadadas",
                    EmailConfirm = "sadsadadas",
                    Gender = 0,
                    Name = "sadasdas",
                    PatientNbr = "sdasdsada",
                    PhoneNbr = "sadsdad"                 
                };

                var response = await httpclient.PostAsync(url, JsonContent.Create(newMOdel)).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
