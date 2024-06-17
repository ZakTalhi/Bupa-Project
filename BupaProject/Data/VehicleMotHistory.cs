using System.Collections.Generic;

namespace BupaProject.Data
{
    public class VehicleMotHistory
    {   
        
        public string? Make { get; set; }

        public string? Model { get; set; }

        public string? primaryColour { get; set; }

        public DateTime MOTExpiryDate { get; set; }

        public int MileageAtLastMOT { get; set; }

        public List<MotTest>? motTests { get; set; }

    }
    public class MotTest
    {
        public string? completedDate { get; set; }
        public string? testResult { get; set; }
        public string? expiryDate { get; set; }
        public string? odometerValue { get; set; }
        public string? odometerUnit { get; set; }
        public string? motTestNumber { get; set; }
        public List<RfrAndComment>? rfrAndComments { get; set; }
    }
    public class RfrAndComment
    {
        public string? text { get; set; }
        public string? type { get; set; }
    }
}
