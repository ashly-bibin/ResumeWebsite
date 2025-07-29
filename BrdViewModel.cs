using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    public class BrdViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ProjectOverview { get; set; }
        public List<string> ProjectObjectives { get; set; }
        public ScopeOfWork ScopeOfWork { get; set; }
        public List<FunctionalRequirement> FunctionalRequirements { get; set; }
        public List<NonFunctionalRequirement> NonFunctionalRequirements { get; set; }
        public List<ProjectPhase> ProjectTimeline { get; set; }
    }
    public class ScopeOfWork
    {
        public List<string> FrontendDevelopment { get; set; }
        public List<string> BackendDevelopment { get; set; }
        public List<string> Integration { get; set; }
        public List<TechStackItem> TechnologyStack { get; set; }
    }

    public class TechStackItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }

    public class FunctionalRequirement
    {
        public string Id { get; set; }
        public string Requirement { get; set; }
        public string Description { get; set; }
    }

    public class NonFunctionalRequirement
    {
        public string Id { get; set; }
        public string Requirement { get; set; }
        public string Description { get; set; }
    }

    public class ProjectPhase
    {
        public string PhaseTitle { get; set; }
        public string PhaseDuration { get; set; }
    }
}