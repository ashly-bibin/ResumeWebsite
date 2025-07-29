using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class SkillItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public int ProficiencyLevel { get; set; } // 0-100
        public string Category { get; set; }
    }

    // Models/SkillViewModel.cs
    public class SkillViewModel
    {
        public List<SkillItem> ProgrammingLanguages { get; set; }
        public List<SkillItem> WebTechnologies { get; set; }
        public List<SkillItem> Databases { get; set; }
        public List<SkillItem> VersionControl { get; set; }
        public List<SkillItem> Frameworks { get; set; }
    }
}
