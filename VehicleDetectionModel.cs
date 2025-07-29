using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class VehicleDetectionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public List<VehicleDetectionResult> DetectionResults { get; set; }
        public DetectionStatistics Statistics { get; set; }
    }

    public class VehicleDetectionResult
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public double Speed { get; set; }
        public string Direction { get; set; }
        public string DetectionTime { get; set; }
    }

    public class DetectionStatistics
    {
        public int TotalVehicles { get; set; }
        public double AverageSpeed { get; set; }
        public int VehiclesOverLimit { get; set; }
    }
}
