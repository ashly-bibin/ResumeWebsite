using ResumeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebsite.Controllers
{
    public class LedgerManagementController : Controller
    {
        // GET: LedgerManagement
        public ActionResult Index()
        {
            var model = GetInitiativeData();
            return View(model);
        }

        private LedgerManagementViewModel GetInitiativeData()
        {
            var employees = new List<Employee>
        {
            new Employee { Name = "JOBY M MICHAEL", EmployeeCode = "64483" },
            new Employee { Name = "AJISH GEORGE", EmployeeCode = "414609" }
        };

            var initiatives = new List<Initiative>
        {
            new Initiative
            {
                Id = 1,
                Title = "Deactivation of Inactive Ledger Codes",
                Objective = "To streamline financial records and improve efficiency by deactivating ledger codes that have not been transacted over the past three years.",
                Actions = new List<InitiativeAction>
                {
                    new InitiativeAction
                    {
                        Title = "Deactivation of Inactive Ledger Codes",
                        Description = "Grant access to the following employees to review and deactivate inactive ledger codes:",
                        Employees = employees
                    },
                    new InitiativeAction
                    {
                        Title = "Reactivation on Demand",
                        Description = "Allow the same department heads to reactivate any deactivated ledger codes as needed, ensuring flexibility and continuity in financial operations."
                    }
                },
                ExpectedOutcome = "This initiative aims to maintain an up-to-date and relevant chart of accounts, enhancing the accuracy of financial reporting."
            },
            new Initiative
            {
                Id = 2,
                Title = "Ledger Code Creation Approval Timeframe",
                Objective = "To ensure timely processing of new ledger code creation requests and maintain the efficiency of financial operations.",
                Actions = new List<InitiativeAction>
                {
                    new InitiativeAction
                    {
                        Title = "Approval Timeframe",
                        Description = "Requests for new ledger code creation must be approved within 24 hours of submission.",
                        Employees = employees
                    },
                    new InitiativeAction
                    {
                        Title = "Automatic Cancellation",
                        Description = "If a request is not approved within the specified timeframe, it will be automatically cancelled by the system."
                    }
                }
            }
        };

            return new LedgerManagementViewModel
            {
                Initiatives = initiatives,
                Note = "Note: Both initiatives involve the same approval personnel (JOBY M MICHAEL and AJISH GEORGE) for consistency in ledger management processes."
            };
        }
    }
}
