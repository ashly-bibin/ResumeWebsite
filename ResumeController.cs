using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace ResumeWebsite.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Resume
        public ActionResult Index()
        {
            // return View();
            var resume = new Resume
            {
                Name = "John Doe",
                Title = "Software Developer",
                Email = "john@example.com",
                Phone = "123-456-7890",
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Company = "ABC Company",
                        Position = "Senior Developer",
                        Duration = "2020 - Present",
                        Description = "Developed web applications using ASP.NET MVC."
                    },
                    new Experience
                    {
                        Company = "XYZ Corp",
                        Position = "Junior Developer",
                        Duration = "2018 - 2020",
                        Description = "Assisted in backend development."
                    }
                },
                Skills = new List<Skill>
                {
                    new Skill { Name = "C#", Level = 5 },
                    new Skill { Name = "JavaScript", Level = 4 },
                    new Skill { Name = "HTML/CSS", Level = 4 },
                    new Skill { Name = "SQL", Level = 3 }
                }
            };

            return View(resume);
        }
    


        public ActionResult Details()
        {
            var resume = new ResumeViewModel
            {
                Name = "ASHLY GEORGE",
                Title = "SOFTWARE DEVELOPER",
                ContactInfo = new ContactInfo
                {
                    Email = "bibiashaeva311@gmail.com",
                    Phone = "9961021140",
                    GitHub = "GitHub Profile",
                    Naukri = "Naukri",
                    Address = "Nankulath House, Pangarapilly, Chelakkara, Thrissur, Kerala 680586"
                },
                ProfessionalSummary = @"Dynamic and results-driven DOT NET Developer with 3 years of robust experience in architecting, implementing, and launching innovative software solutions. Highly skilled in utilizing DOT NET technologies such as C#, ASP.NET, SQL Server, and MVC (beginner) to develop scalable and high-performance applications. Renowned for enhancing system performance, elevating user interfaces, and resolving complex technical challenges with creative and effective solutions.",
                TechnicalSkills = new List<string>
            {
                "• Programming Languages: ASP.NET",
                "• Web Technologies: HTML, CSS, Bootstrap, JavaScript,Ajax",
                "• Databases: PLSQL, SQL",
                "• Version Control: Git",
                "• Frameworks: .NET Framework"
            },
                WorkHistory = new List<WorkExperience>
            {
                new WorkExperience
                {
                    Period = "July 2022 - Present",
                    Company = "Manappuram Finance Limited",
                    Location = "Valapad, Thrissur",
                    Position = "Software Developer",
                    Responsibilities = new List<string>
                    {
                        "Design, develop, and modify Microsoft ASP.NET applications, Web Services, and components.",
                        "Maintain SQL database schemas and scripts, including views and stored procedures.",
                        "Client-side development using HTML, CSS, JavaScript, and jQuery.",
                        "Deploy .NET systems to production environments and troubleshoot issues.",
                        "Optimize database queries and procedures to improve performance."
                    }
                },
                new WorkExperience
                {
                    Period = "August 2021 - February 2022",
                    Company = "Quest",
                    Location = "Kochi",
                    Position = "Internship",
                    Responsibilities = new List<string>
                    {
                        "Focused on Python Full Stack Development - Vehicle Detection And Speed Tracking"
                    }
                }
            },
                Education = new List<Education>
            {
                new Education
                {
                    Year = "March 2021",
                    Institution = "Nehru College of Engineering and Research Center, Pampady, Thrissur",
                    Degree = "MCA - KTU"
                },
                new Education
                {
                    Year = "March 2019",
                    Institution = "IHRD Chelakkara",
                    Degree = "BCA - Calicut University"
                }
            },
                Projects = new List<Project>
            {
                new Project
                {
                    Name = "BRD Module",
                    Description = "Created a new module for Business Requirement Document (BRD) ID creation with integrated alerts for pending tasks."
                },
                new Project
                {
                    Name = "Request for Sub Customer Wise Report",
                    Description = "Developed access to generate reports directly from the module, with a need to separate live and closed accounts."
                }
            }
            };

            return View(resume);
        }

        
    }
}

