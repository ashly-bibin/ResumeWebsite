using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeWebsite.Models;

namespace ResumeWebsite.Controllers
{
    public class BrdController : Controller
    {
        // GET: Brd
        public ActionResult Index()
        {
            var model = new BrdViewModel
            {
                Title = "Business Requirement Document (BRD)",
                Subtitle = "A comprehensive document outlining requirements for a web-based application developed using C#, PL/SQL, HTML, JavaScript, and AJAX",
                ProjectOverview = "The purpose of this Business Requirement Document (BRD) is to outline the requirements for a web-based application developed using C#, PL/SQL, HTML, JavaScript, and AJAX. This application aims to streamline business processes, enhance user experience, and improve data management.",
                ProjectObjectives = new List<string>
                {
                    "Develop a user-friendly web application that meets business needs",
                    "Ensure seamless integration with existing systems",
                    "Provide real-time data processing and reporting capabilities",
                    "Enhance user engagement through interactive features"
                },
                ScopeOfWork = new ScopeOfWork
                {
                    FrontendDevelopment = new List<string>
                    {
                        "HTML: Structure the web pages",
                        "CSS: Style the application for a responsive design",
                        "JavaScript: Implement client-side logic and interactivity",
                        "AJAX: Enable asynchronous data loading for a smoother user experience"
                    },
                    BackendDevelopment = new List<string>
                    {
                        "C#: Develop the server-side logic and APIs",
                        "PL/SQL: Manage database interactions and data processing"
                    },
                    Integration = new List<string>
                    {
                        "Connect the frontend with the backend services",
                        "Ensure data flow between the application and the database"
                    },
                    TechnologyStack = new List<TechStackItem>
                    {
                        new TechStackItem { Name = "HTML", Icon = "fab fa-html5" },
                        new TechStackItem { Name = "CSS", Icon = "fab fa-css3-alt" },
                        new TechStackItem { Name = "JavaScript", Icon = "fab fa-js" },
                        new TechStackItem { Name = "C#", Icon = "fas fa-code" }, // Using code icon as placeholder
                        new TechStackItem { Name = "PL/SQL", Icon = "fas fa-database" },
                        new TechStackItem { Name = "AJAX", Icon = "fas fa-exchange-alt" }
                    }
                }, // Fixed missing comma here
                FunctionalRequirements = new List<FunctionalRequirement>
                {
                    new FunctionalRequirement { Id = "FR1", Requirement = "User Authentication", Description = "Users must be able to register and log in securely" },
                    new FunctionalRequirement { Id = "FR2", Requirement = "Data Entry Forms", Description = "Users can input data through forms that validate input" },
                    new FunctionalRequirement { Id = "FR3", Requirement = "Data Retrieval", Description = "Users can retrieve and view data from the database" },
                    new FunctionalRequirement { Id = "FR4", Requirement = "Reporting", Description = "Generate reports based on user-defined criteria" },
                    new FunctionalRequirement { Id = "FR5", Requirement = "Notifications", Description = "Users receive notifications for important updates" }
                },
                NonFunctionalRequirements = new List<NonFunctionalRequirement>
                {
                    new NonFunctionalRequirement { Id = "NFR1", Requirement = "Performance", Description = "The application should load within 2 seconds" },
                    new NonFunctionalRequirement { Id = "NFR2", Requirement = "Security", Description = "Implement encryption for sensitive data" },
                    new NonFunctionalRequirement { Id = "NFR3", Requirement = "Usability", Description = "The application should be intuitive and easy to navigate" },
                    new NonFunctionalRequirement { Id = "NFR4", Requirement = "Scalability", Description = "The system should handle up to 1000 concurrent users" }
                },
                ProjectTimeline = new List<ProjectPhase>
                {
                    new ProjectPhase { PhaseTitle = "Phase 1: Requirements Gathering", PhaseDuration = "2 weeks" },
                    new ProjectPhase { PhaseTitle = "Phase 2: Design", PhaseDuration = "3 weeks" },
                    new ProjectPhase { PhaseTitle = "Phase 3: Development", PhaseDuration = "6 weeks" },
                    new ProjectPhase { PhaseTitle = "Phase 4: Testing", PhaseDuration = "3 weeks" },
                    new ProjectPhase { PhaseTitle = "Phase 5: Deployment", PhaseDuration = "2 weeks" }
                } // Fixed missing closing parenthesis here
            };

            return View(model); // Added return statement
        }
    }
}