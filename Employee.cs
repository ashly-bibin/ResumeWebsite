using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebsite.Models
{
    // Employee.cs
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
    }

    // InitiativeAction.cs
    public class InitiativeAction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }

    // Initiative.cs
    public class Initiative
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Objective { get; set; }
        public List<InitiativeAction> Actions { get; set; } = new List<InitiativeAction>();
        public string ExpectedOutcome { get; set; }
    }

    // LedgerManagementViewModel.cs
    public class LedgerManagementViewModel
    {
        public List<Initiative> Initiatives { get; set; }
        public string Note { get; set; }
    }
}