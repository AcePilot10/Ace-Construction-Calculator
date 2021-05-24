using System;
using System.Collections.Generic;
using AceConstructionCalculator.Enums;
using AceConstructionCalculator.Helpers;
using AceConstructionCalculator.Models;
using Syncfusion.XForms.Accordion;
using Xamarin.Forms;
using System.Linq;
using AceConstructionCalculator.ViewModels.Creation;
using Syncfusion.XForms.Expander;

namespace AceConstructionCalculator.Views.Creation
{
    public partial class ProjectResult : ContentView
    {
        private ProjectResultViewModel ViewModel
        {
            get
            {
                return BindingContext as ProjectResultViewModel;
            }
        }

        private ExpenseLoader _expenseLoader = new ExpenseLoader();

        public ProjectResult(ProjectResultsModel result)
        {
            InitializeComponent();
            BindingContext = new ProjectResultViewModel(result);
            BuildResults();
        }

        public ProjectResult(ProjectResultsModel result, Action onReturn)
        {
            InitializeComponent();
            BindingContext = new ProjectResultViewModel(result, onReturn);
            BuildResults();
        }

        private void BuildResults()
        {    
            for (int i = 0; i < typeof(Categories).GetEnumNames().Length; i++)
            {
                SfExpander expander = new SfExpander()
                {
                    IsExpanded = false
                };
                Grid head = new Grid();
                StackLayout content = new StackLayout();

                Categories category = (Categories)i;

                Label headerLabel = new Label()
                {
                    Text = EnumToStringName.CategoryToTitle(category)
                };
                head.Children.Add(headerLabel);

                foreach(var expense in ViewModel.Result.Pricing.Values.Where(x => x.Category == category))
                {
                    var price = ViewModel.Result.SubTotals[expense.ExpenseRef];
                    Label label = new Label()
                    {
                        Text = expense.Name + ": " + price.ToString("C"),
                        TextColor = Color.White
                    };
                    content.Children.Add(label);
                }

                expander.Content = content;
                expander.Header = head;
                categoryBreakdownHolder.Children.Add(expander);
            }
        }
    }
}