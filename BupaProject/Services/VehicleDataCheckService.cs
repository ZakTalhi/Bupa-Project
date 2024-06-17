using BupaProject.Data;

namespace BupaProject.Services
{
    public class VehicleDataCheckService
    {
        private readonly HttpClient _httpClient;

        public VehicleDataCheckService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<VehicleMotHistory>> GetMotTestHistoryAsync(string registration)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-api-key", "Place you API key here");
                    var url = $"https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration={registration}";
                    var response = await client.GetAsync(url);

                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadFromJsonAsync<List<VehicleMotHistory>>();
                }
            }
            catch (Exception ex)
            {
                return new List<VehicleMotHistory>();
            }
        }
    }
}

