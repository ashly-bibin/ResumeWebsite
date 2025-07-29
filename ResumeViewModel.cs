using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    // Models/ResumeViewModel.cs
    public class ResumeViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public string ProfessionalSummary { get; set; }
        public List<string> TechnicalSkills { get; set; }
        public List<WorkExperience> WorkHistory { get; set; }
        public List<Education> Education { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class ContactInfo
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GitHub { get; set; }
        public string Naukri { get; set; }
        public string Address { get; set; }
    }

    public class WorkExperience
    {
        public string Period { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Position { get; set; }
        public List<string> Responsibilities { get; set; }
    }

    public class Education
    {
        public string Year { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}