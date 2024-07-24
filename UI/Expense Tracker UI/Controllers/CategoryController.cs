using Expense_Tracker_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expense_Tracker_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryForm()
        {
            return View();
        }

        public IActionResult CategoryInvoice()
        {
            return View();
        }
    }
}