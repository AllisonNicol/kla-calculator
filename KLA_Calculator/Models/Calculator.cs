using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NCalc;

namespace KLA_Calculator.Models
{
  public class Calculator
  {
    [Required()]
    [RegularExpression("^[0-9.()]+[0-9.+*\\/×÷%() -]*$", ErrorMessage = "Formula must start with a number/decimal and can only include the numbers 0-9 or the symbols () . + - * × / ÷ %")]
    public string Formula
    {
      get;
      set;
    }

    [ReadOnly(true)]
    public string Answer
    {
      get;
      set;
    }

    public bool ValidFormula
    {
      get;
      set;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Calculator"/> class.
    /// </summary>
    public Calculator()
    {
      this.ValidFormula = true;
    }

    public void CalculateFormula()
    {
      // replace multiplication and division signs with the versions NCalc likes
      this.Formula = this.Formula.Replace('×', '*').Replace('÷', '/');

      Expression e = new Expression(this.Formula);

      this.ValidFormula = !e.HasErrors();

      if (this.ValidFormula)
      {
        this.Answer = e.Evaluate().ToString();
      }
    }
  }
}