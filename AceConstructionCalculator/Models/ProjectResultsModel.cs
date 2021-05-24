using System;
using System.Collections.Generic;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Models
{
    public class ProjectResultsModel
    {
        public ProjectExpensePricing Pricing { get; set; }
        public NewProjectConfigDataForm Config { get; set; }
        public double GrandTotal { get; set; }
        public Dictionary<Expenses, double> SubTotals { get; set; } = new Dictionary<Expenses, double>();
        public string Name { get; set; }
        public int TotalSquareFootage { get; set; }
        public int LivingSquareFootage { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}