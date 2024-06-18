using BupaProject.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BupaProject.Test
{
    public class VehicleDataCheckServiceTests
    {
        [Fact]
        public async Task GetMotTestHistoryAsync_ValidRegistration_ReturnsMotHistory()
        {
            // Arrange
            var httpClient = new HttpClient(); 
            var service = new VehicleDataCheckService(httpClient);
            var registration = "FY10DZA";

            // Act
            var motHistory = await service.GetMotTestHistoryAsync(registration);

            // Assert
            Assert.NotNull(motHistory);
            
        }
    }
}
