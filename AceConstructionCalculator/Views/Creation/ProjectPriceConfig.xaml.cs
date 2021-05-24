using System;
using System.Collections.Generic;
using System.Linq;
using AceConstructionCalculator.Enums;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.ViewModels.Creation.Steps;
using Syncfusion.XForms.Border;
using Xamarin.Forms;

namespace AceConstructionCalculator.Views.Creation.Steps
{
    public partial class ProjectPriceConfig : ContentView
    {
        private List<ExpenseEntry> _expenseEntries = new List<ExpenseEntry>();

        public ProjectPriceConfigViewModel ViewModel
        {
            get
            {
                return BindingContext as ProjectPriceConfigViewModel;
            }
        }

        public ProjectPriceConfig(NewProjectConfigDataForm config)
        {
            InitializeComponent();
            BindingContext = new ProjectPriceConfigViewModel(Categories.SITE_PREP, config);
            LoadForm(0);
        }

        public void Next()
        {
            int currentStep = (int)ViewModel.CurrentCategory;
            if (currentStep < typeof(Categories).GetEnumNames().Length - 1)
            {
                Categories nextStep = (Categories)currentStep + 1;
                SaveValues();
                LoadForm(nextStep);
            }
            else
            {
                ViewModel.ShowResults();
            }
        }

        public void Back()
        {
            int currentStep = (int)ViewModel.CurrentCategory;
            Categories currentCategory = (Categories)currentStep;
            if (ViewModel.Expenses.Any(x => x.Category == currentCategory))
            {
                ViewModel.Expenses = ViewModel.Expenses.Where(x => x.Category != currentCategory).ToList();
            }
            if (currentStep > 0)
            {
                Categories nextStep = (Categories)currentStep - 1;
                LoadForm(nextStep);
            }
            else
            {
                MainPage.Instance.ChangeScreen(new NewProjectConfiguration(ViewModel.ProjectConfig));
            }
        }

        private void LoadForm(Categories category)
        {
            _expenseEntries.Clear();
            contentStack.Children.Clear();
            ViewModel.LoadExpenses(category);
            var model = BindingContext as ProjectPriceConfigViewModel;

            Label lblExpense = new Label()
            {
                Text = "Expense",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                FontSize = 20
            };
            Label lblPrice = new Label()
            {
                Text = "Price",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 20

            };
            Label lblVariable = new Label()
            {
                Text = "Variable",
                HorizontalOptions = LayoutOptions.EndAndExpand,
                FontSize = 20
            };

            StackLayout titleStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Margin = 20
            };

            titleStack.Children.Add(lblExpense);
            titleStack.Children.Add(lblPrice);
            titleStack.Children.Add(lblVariable);

            contentStack.Children.Add(titleStack);

            for (int i = 0; i < model.Expenses.Count; i++)
            {
                Expense expense = model.Expenses[i];

                var name = expense.Name;
                var price = expense.Price;

                string pricingMethod = null;
                switch (expense.PricingMethod)
                {
                    case Enums.PricingMethods.CONSTANT:
                        pricingMethod = "Constant";
                        break;
                    case Enums.PricingMethods.LSF:
                        pricingMethod = "Living Square Footage";
                        break;
                    case Enums.PricingMethods.TSF:
                        pricingMethod = "Total Square Footage";
                        break;
                    case Enums.PricingMethods.VARIABLE:
                        pricingMethod = expense.CustomPricingMethod;
                        break;
                }

                Label nameLabel = new Label()
                {
                    Text = name,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.StartAndExpand
                };

                Entry priceEntry = new Entry()
                {
                    Placeholder = "Price",
                    Text = price.ToString("C"),
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                Label pricingMethodLabel = new Label()
                {
                    Text = pricingMethod,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };

                Grid grid = new Grid()
                {
                    HeightRequest = 50,
                    Margin = 10
                };
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });

                grid.Children.Add(nameLabel, 0, 0);
                grid.Children.Add(priceEntry, 1, 0);
                grid.Children.Add(pricingMethodLabel, 2, 0);

                contentStack.Children.Add(grid);

                _expenseEntries.Add(new ExpenseEntry()
                {
                    Entry = priceEntry,
                    Expense = expense
                });
            }
        }

        private struct ExpenseEntry
        {
            public Entry Entry { get; set; }
            public Expense Expense { get; set; }
        }

        private void SaveValues()
        {
            foreach(var expenseEntry in _expenseEntries)
            {
                var price = double.Parse(expenseEntry.Entry.Text.Replace("$", ""));
                expenseEntry.Expense.Price = price;
                ViewModel.AddResult(expenseEntry.Expense);
            }
        }

        public void ShowResults()
        {
            ViewModel.ShowResults();
        }
    }
}