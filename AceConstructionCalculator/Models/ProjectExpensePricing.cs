using System;
using System.Collections.Generic;

namespace AceConstructionCalculator.Models
{
    public class ProjectExpensePricing
    {
        public List<Expense> Values { get; private set; } = new List<Expense>();

        public void AddResult(Expense expense)
        {
            Values.Add(expense);
        }
    }
}
