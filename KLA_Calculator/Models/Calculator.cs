using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NCalc;

namespace KLA_Calculator.Models
{
  /// <summary>
  /// Holds and processes calculator data.
  /// </summary>
  public class Calculator
  {
    /// <summary>
    /// Gets or sets the formula to be evaluated.
    /// </summary>
    [MaxLength(28, ErrorMessage = "A maximum of 28 characters can be entered")]
    [Required]
    [RegularExpression("^[0-9.()]+[0-9.+*\\/×÷%() -]*$", ErrorMessage = "Formula must start with a number or decimal and can only include 0-9 or the symbols () . + - * × / ÷ %")]
    public string Formula
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the answer to be displayed to the user.
    /// </summary>
    [ReadOnly(true)]
    public string Answer
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the formula is valid.
    /// </summary>
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

    /// <summary>
    /// Evaluates the current formula.
    /// </summary>
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