using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeWebsite.Models;

namespace ResumeWebsite.Controllers
{
    public class VehicleDetectionController : Controller
    {
        // GET: VehicleDetection
        public ActionResult Index()
        {
            var model = new VehicleDetectionModel
            {
                Title = "Vehicle Detection and Speed Tracking",
                Description = "This project involves creating a web application that detects vehicles in real-time using computer vision and tracks their speed.",
                Technologies = new List<string>
                {
                    "Frontend: HTML, CSS, JavaScript",
                    "Backend: Python, Flask and Django",
                    "Database: SQLite",
                    "Computer Vision: OpenCV"
                },
                DetectionResults = new List<VehicleDetectionResult>
                {
                    new VehicleDetectionResult
                    {
                        Id = 1,
                        VehicleType = "Car",
                        Speed = 65.2,
                        Direction = "Northbound",
                        DetectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    },
                    new VehicleDetectionResult
                    {
                        Id = 2,
                        VehicleType = "Truck",
                        Speed = 58.7,
                        Direction = "Southbound",
                        DetectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    },
                    new VehicleDetectionResult
                    {
                        Id = 3,
                        VehicleType = "Motorcycle",
                        Speed = 72.3,
                        Direction = "Eastbound",
                        DetectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    }
                },
                Statistics = new DetectionStatistics
                {
                    TotalVehicles = 3,
                    AverageSpeed = 65.4,
                    VehiclesOverLimit = 1
                }
            };

            return View(model);
        }

        // AJAX endpoint for real-time updates
        [HttpGet]
        public JsonResult GetRealTimeDetections()
        {
            // In a real implementation, this would connect to your Python backend
            // For demo purposes, we'll return mock data
            var results = new List<VehicleDetectionResult>
            {
                new VehicleDetectionResult
                {
                    Id = 4,
                    VehicleType = "SUV",
                    Speed = 62.1,
                    Direction = "Westbound",
                    DetectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                }
            };

            return Json(results, JsonRequestBehavior.AllowGet);
        }

        // POST endpoint for processing detection data
        [HttpPost]
        public JsonResult ProcessDetection(VehicleDetectionResult detection)
        {
            // In a real implementation, this would process the detection
            // and save to database
            detection.Id = new Random().Next(1000, 9999);
            detection.DetectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            return Json(new { success = true, data = detection });
        }
    }

}
    
