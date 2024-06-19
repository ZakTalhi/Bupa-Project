﻿using BupaProject.Data;
using Serilog;

namespace BupaProject.Services
{
    public class VehicleDataCheckService
    {
        private readonly HttpClient _httpClient;

        public VehicleDataCheckService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<VehicleMotHistory> GetMotTestHistoryAsync(string registration)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-api-key", "place apikey here");
                    var url = $"https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration={registration}";
                    var response = await client.GetAsync(url);

                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();
                    var result = await response.Content.ReadFromJsonAsync<List<VehicleMotHistory>>();
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred while fetching MOT history for registration: {Registration}", registration);

                return null;
            }
        }
    }
}

