using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebsite.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        public ActionResult Index()
        {
            var viewModel = new SkillViewModel
            {
                ProgrammingLanguages = new List<SkillItem>
            {
                new SkillItem
                {
                    Name = "ASP.NET",
                    Icon = "fab fa-microsoft",
                    ProficiencyLevel = 90,
                    Category = "Programming Languages"
                }
            },

                WebTechnologies = new List<SkillItem>
            {
                new SkillItem { Name = "HTML", Icon = "fab fa-html5", ProficiencyLevel = 95, Category = "Web Technologies" },
                new SkillItem { Name = "CSS", Icon = "fab fa-css3-alt", ProficiencyLevel = 90, Category = "Web Technologies" },
                new SkillItem { Name = "Bootstrap", Icon = "fab fa-bootstrap", ProficiencyLevel = 85, Category = "Web Technologies" },
                new SkillItem { Name = "JavaScript", Icon = "fab fa-js", ProficiencyLevel = 80, Category = "Web Technologies" },
                new SkillItem { Name = "Ajax", Icon = "fas fa-exchange-alt", ProficiencyLevel = 75, Category = "Web Technologies" }
            },

                Databases = new List<SkillItem>
            {
                new SkillItem { Name = "PLSQL", Icon = "fas fa-database", ProficiencyLevel = 85, Category = "Databases" },
                new SkillItem { Name = "SQL", Icon = "fas fa-table", ProficiencyLevel = 90, Category = "Databases" }
            },

                VersionControl = new List<SkillItem>
            {
                new SkillItem { Name = "Git", Icon = "fab fa-git-alt", ProficiencyLevel = 85, Category = "Version Control" },
                new SkillItem { Name = "GitHub", Icon = "fab fa-github", ProficiencyLevel = 80, Category = "Version Control" }
            },

                Frameworks = new List<SkillItem>
            {
                new SkillItem { Name = ".NET Framework", Icon = "fas fa-cubes", ProficiencyLevel = 90, Category = "Frameworks" },
                new SkillItem { Name = "ASP.NET MVC", Icon = "fas fa-code", ProficiencyLevel = 85, Category = "Frameworks" }
            }
            };

            return View(viewModel);
        }
    }
}
    
