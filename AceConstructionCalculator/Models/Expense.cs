using System;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Models
{
    public class Expense : Attribute
    {
        public Categories Category { get; set; }
        public PricingMethods PricingMethod { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string CustomPricingMethod { get; set; }
        public Expenses ExpenseRef { get; set; }

        public Expense(string name)
        {
            Name = name;
        }

        public Expense() { }
    }
}
