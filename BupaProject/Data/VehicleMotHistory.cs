using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BupaProject.Data
{

    public class MotTest
    {
        [JsonProperty("completedDate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("testResult", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("testResult")]
        public string TestResult { get; set; }

        [JsonProperty("expiryDate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("odometerValue", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("odometerValue")]
        public string OdometerValue { get; set; }

        [JsonProperty("odometerUnit", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("odometerUnit")]
        public string OdometerUnit { get; set; }

        [JsonProperty("motTestNumber", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("motTestNumber")]
        public string MotTestNumber { get; set; }

        [JsonProperty("rfrAndComments", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("rfrAndComments")]
        public List<RfrAndComment> RfrAndComments { get; set; }
    }

    public class RfrAndComment
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class VehicleMotHistory
    {
        [JsonProperty("registration", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("registration")]
        public string Registration { get; set; }

        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("make")]
        public string Make { get; set; }

        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonProperty("firstUsedDate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("firstUsedDate")]
        public string FirstUsedDate { get; set; }

        [JsonProperty("fuelType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("fuelType")]
        public string FuelType { get; set; }

        [JsonProperty("primaryColour", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("motTests", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("motTests")]
        public List<MotTest> MotTests { get; set; } = new List<MotTest>();
    }

}
