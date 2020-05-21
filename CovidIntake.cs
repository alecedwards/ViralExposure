using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
namespace ViralExposure
{
    public class CovidIntake
    {
        public async Task RunJob()
        {
            var http = new HttpClient();
            using var response = await http.GetAsync("https://data.ct.gov/resource/28fr-iqnx.json");
            var db = new CovidContext();
            var content = await response.Content.ReadAsStreamAsync();
            var c = await response.Content.ReadAsStringAsync();
            var results = await JsonSerializer.DeserializeAsync<List<TownCovidInfo>>(content);

            for(int i = 0; i < 169; i++) 
            {
                db.Add(results[i]);
            }
            db.SaveChanges();
        }
    }
}