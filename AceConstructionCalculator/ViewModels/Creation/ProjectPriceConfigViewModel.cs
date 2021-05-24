using System;
using System.Collections.Generic;
using AceConstructionCalculator.Enums;
using AceConstructionCalculator.Helpers;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Views.Creation;

namespace AceConstructionCalculator.ViewModels.Creation.Steps
{
    public class ProjectPriceConfigViewModel
    {
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public Categories CurrentCategory { get; set; }

        private ExpenseLoader _expenseLoader = new ExpenseLoader();
        private ProjectExpensePricing _pricing = new ProjectExpensePricing();
        private NewProjectConfigDataForm _projectConfig;

        public NewProjectConfigDataForm ProjectConfig
        {
            get
            {
                return _projectConfig;
            }
        }

        public ProjectPriceConfigViewModel(Enums.Categories category, NewProjectConfigDataForm config)
        {
            _projectConfig = config;
            LoadExpenses(category);
        }

        public void LoadExpenses(Categories category)
        {
            Expenses.Clear();
            CurrentCategory = category;
            var properties = _expenseLoader.GetType().GetProperties();
            foreach (var property in properties)
            {
                Expense currentExpense = property.GetValue(_expenseLoader) as Expense;
                if (currentExpense.Category == category)
                {
                    Expenses.Add(currentExpense);
                }
            }
        }

        public void AddResult(Expense expense)
        {
            _pricing.Values.Add(expense);
        }

        public void ShowResults()
        {
            var result = CalculationHelper.CalculateTotal(_projectConfig, _pricing);
            MainPage.Instance.ChangeScreen(new ProjectResult(result));
        }
    }
}