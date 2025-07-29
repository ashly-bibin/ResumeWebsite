using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebsite.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult ProfessionalSummary()
        {
            var model = new ProfessionalSummaryModel
            {
                Summary = "Dynamic and results-driven DOT NET Developer with 3 years of robust experience in architecting, implementing, and launching innovative software solutions.",
                YearsOfExperience = 3,
                KeySkills = new List<string>
            {
                "C#",
                "ASP.NET",
                "SQL Server",
                "MVC (beginner)"
            },
                Achievements = new List<string>
            {
                "Enhancing system performance",
                "Elevating user interfaces",
                "Resolving complex technical challenges with creative and effective solutions"
            }
            };

            return View(model);
        }
    }
}
