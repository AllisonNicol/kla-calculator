using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KLA_Calculator.Models;

namespace KLA_Calculator.Controllers
{
  /// <summary>
  /// Main controller for calculator application.
  /// </summary>
  public class CalculatorController : Controller
  {
    /// <summary>
    /// GET action for calculator--used when page is initially loaded.
    /// </summary>
    /// <returns>Calculator view</returns>
    public ActionResult Index()
    {
      Calculator calculator = new Calculator();
      return this.View(calculator);
    }

    /// <summary>
    /// POST action for calculator--used when submitting a formula for evaluation.
    /// </summary>
    /// <param name="calculator">Data for calculator</param>
    /// <returns>Calculator view</returns>
    [HttpPost]
    public ActionResult Index(Calculator calculator)
    {
      calculator.CalculateFormula();

      return this.View(calculator);
    }
  }
}
