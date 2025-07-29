using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebsite.Controllers
{
    public class WorkHistoryController : Controller
    {
        public ActionResult Index()
        {
            var model = new WorkHistoryViewModel();

            // Current job
            var currentJob = new WorkExperience
            {
                Period = "July 2022 - Present",
                Position = "Software Developer",
                Company = "Manappuram Finance Limited",
                Location = "Valapad, Thrissur",
                Responsibilities = new List<string>
            {
                "Design, develop, and modify Microsoft ASP.NET applications, Web Services, and components.",
                "Maintain SQL database schemas and scripts, including views and stored procedures.",
                "Client-side development using HTML, CSS, JavaScript, and jQuery.",
                "Deploy .NET systems to production environments and troubleshoot issues.",
                "Optimize database queries and procedures to improve performance."
            }
            };

            // Internship
            var internship = new WorkExperience
            {
                Period = "August 2021 - February 2022",
                Position = "Internship",
                Company = "Quest",
                Location = "Kochi",
                Responsibilities = new List<string>
            {
                "Focused on Python Full Stack Development - Vehicle Detection And Speed Tracking"
            }
            };

            model.Experiences.Add(currentJob);
            model.Experiences.Add(internship);

            return View(model);
        }
    }

}