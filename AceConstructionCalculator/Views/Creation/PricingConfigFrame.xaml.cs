using System;
using System.Collections.Generic;
using System.Linq;
using AceConstructionCalculator.Enums;
using AceConstructionCalculator.Helpers;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.ViewModels.Creation;
using AceConstructionCalculator.Views.Creation.Steps;
using Syncfusion.XForms.ProgressBar;
using Xamarin.Forms;

namespace AceConstructionCalculator.Views.Creation
{
    public partial class PricingConfigFrame : ContentView
    {
        private int currentStep = 0;
        private ProjectPriceConfig priceConfigView;

        private PricingConfigFrameViewModel ViewModel
        {
            get
            {
                return BindingContext as PricingConfigFrameViewModel;
            }
        }

        public PricingConfigFrame(NewProjectConfigDataForm projectConfig)
        {
            InitializeComponent();
            BindingContext = new PricingConfigFrameViewModel();
            priceConfigView = new ProjectPriceConfig(projectConfig)
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            content.Children.Add(priceConfigView);
            (BindingContext as PricingConfigFrameViewModel).CurrentCategory = EnumToStringName.CategoryToTitle(((Categories)0));
            BuildProgressBar();
        }

        private void BuildProgressBar()
        {
            int segments = typeof(Categories).GetEnumNames().Length - 1;
            progressBar.SegmentCount = segments;
        }

        void btnNext_Clicked(System.Object sender, System.EventArgs e)
        {
            currentStep++;
            (BindingContext as PricingConfigFrameViewModel).CurrentCategory = EnumToStringName.CategoryToTitle((Categories)currentStep);

            double progress = (double)currentStep / (double)progressBar.SegmentCount * 100.0;
            progressBar.Progress = progress;

            if (currentStep == typeof(Categories).GetEnumNames().Length - 1)
                btnNext.Text = "Calculate";

            priceConfigView.Next();
        }
       
        void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            if (btnNext.Text == "Calculate")
                btnNext.Text = "Next";
            priceConfigView.Back();
            currentStep--;
            (BindingContext as PricingConfigFrameViewModel).CurrentCategory = EnumToStringName.CategoryToTitle((Categories)currentStep);

        }
    }
}