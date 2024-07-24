using Expense_Tracker_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expense_Tracker_UI.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult ExpenseForm()
        {
            return View();
        }

        public IActionResult ExpenseInvoice()
        {
            return View();
        }
    }
}