using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class ContactModel
    {
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string GitHubUrl { get; set; }
        public string NaukriUrl { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
