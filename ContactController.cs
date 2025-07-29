using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebsite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            var model = new ContactModel
            {
                FullName = "ASHLY GEORGE",
                JobTitle = "SOFTWARE DEVELOPER",
                Email = "bibiashaeva311@gmail.com",
                GitHubUrl = "https://github.com/yourusername", // Replace with actual URL
                NaukriUrl = "https://www.naukri.com/mnjuser/profile?id=&altresid", // Replace with actual URL
                Phone = "9961021140",
                Address = "Nankulath House, Pangarapilly, Chelakkara, Thrissur, Kerala 680586"
            };

            return View(model);
        }
    }
}
