using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KLA_Calculator.Models;

namespace KLA_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
          Calculator calculator = new Calculator();
          return View(calculator);
        }

        // POST: Calculator
        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
          calculator.CalculateFormula();

          return View(calculator);
        }
    }
}
