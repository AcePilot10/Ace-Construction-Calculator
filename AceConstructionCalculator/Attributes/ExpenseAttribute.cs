using System;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Attributes
{
    public class ExpenseAttribute : Attribute
    {
        public Expenses Expense { get; set; }
    }
}
