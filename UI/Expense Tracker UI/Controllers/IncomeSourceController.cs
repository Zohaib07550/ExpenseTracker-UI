using Expense_Tracker_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expense_Tracker_UI.Controllers
{
    public class IncomeSourcesController : Controller
    {
        public IActionResult IncomeForm()
        {
            return View();
        }

        public IActionResult IncomeInvoice()
        {
            return View();
        }
    }
}