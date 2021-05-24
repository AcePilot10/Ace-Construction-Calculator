using System;
using System.Collections;
using System.Collections.Generic;

namespace AceConstructionCalculator.Models
{
    public class Project
    {
        public string Name { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }
        public decimal Total { get; set; }
    }
}