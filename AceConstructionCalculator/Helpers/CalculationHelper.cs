using System;
using AceConstructionCalculator.Models;
using System.Linq;
using AceConstructionCalculator.Attributes;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Helpers
{
    public class CalculationHelper
    {
        public static ProjectResultsModel CalculateTotal(NewProjectConfigDataForm config,
                                                ProjectExpensePricing prices)
        {
            ProjectResultsModel results = new ProjectResultsModel()
            {
                Config = config,
                Pricing = prices,
                Name = config.Name,
                CreationDate = DateTime.Now
            };

            double total = 0;

            foreach(var expense in prices.Values)
            {
                double price = 0;

                if (expense.PricingMethod == PricingMethods.CONSTANT)
                    price = expense.Price;

                else if (expense.PricingMethod == PricingMethods.TSF)
                    price = expense.Price * config.TotalSquareFootage;

                else if (expense.PricingMethod == PricingMethods.LSF)
                    price = expense.Price * config.LivingSquareFootage;

                else if(expense.PricingMethod == PricingMethods.VARIABLE)
                {
                    foreach (var property in config.GetType().GetProperties())
                    {
                        if (property.GetCustomAttributes(false).ToList().Any(x => x.GetType() == typeof(ExpenseAttribute)))
                        {
                            ExpenseAttribute expenseRefAttribute = property.GetCustomAttributes(false).ToList().Single(x => x.GetType() == typeof(ExpenseAttribute)) as ExpenseAttribute;
                            Expenses currentExpenseRef = expenseRefAttribute.Expense;
                            if (expense.ExpenseRef == currentExpenseRef)
                            {
                                Expense expenseValue = prices.Values.Single(x => x.ExpenseRef == currentExpenseRef);
                                int amountValue = (int)property.GetValue(config);
                                price = expenseValue.Price * amountValue;
                                total += price;
                                break;
                            }
                            else
                                continue;
                        }
                    }

                }

                else continue;

                results.SubTotals.Add(expense.ExpenseRef, price);
                total += price;
            }

            results.GrandTotal = total;

            return results;
        }
    }
}