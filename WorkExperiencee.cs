using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class WorkExperiencee
    {
        public string Period { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public List<string> Responsibilities { get; set; }
    }

    // Models/WorkHistoryViewModel.cs
    public class WorkHistoryViewModel
    {
        public List<WorkExperience> Experiences { get; set; }

        public WorkHistoryViewModel()
        {
            Experiences = new List<WorkExperience>();
        }
    }
}
