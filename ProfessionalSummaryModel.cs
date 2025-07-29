using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class ProfessionalSummaryModel
    {
        public string Summary { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> KeySkills { get; set; }
        public List<string> Achievements { get; set; }
    }
}
