using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    
    public class Resume
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Experience
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; } // 1-5 scale
    }
}