using System;
using System.Collections.Generic;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.ViewModels.Creation;
using Xamarin.Forms;

namespace AceConstructionCalculator.Views.Creation
{
    public partial class NewProjectConfiguration : ContentView
    {
        public NewProjectConfiguration()
        {
            BindingContext = new NewProjectConfigurationViewModel();
            InitializeComponent();
        }

        public NewProjectConfiguration(NewProjectConfigDataForm dataForm)
        {
            InitializeComponent();
            BindingContext = new NewProjectConfigurationViewModel(dataForm);
        }

        void Entry_Focused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var entry = sender as Entry;
            entry.BackgroundColor = Color.Blue;
        }

        void Entry_Unfocused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var entry = sender as Entry;
            entry.BackgroundColor = Color.White;
        }

        void btnContinue_Clicked(System.Object sender, System.EventArgs e)
        {
            // For debugging, disabling validation
            if (newProjectConfig.Validate())
            {
                (BindingContext as NewProjectConfigurationViewModel).ContinueCommand.Execute(newProjectConfig.DataObject);
            }
            else
            {
                MainPage.Instance.DisplayAlert("Cannot Continue", "Please Fill In All Required Fields", "Return");
                return;
            }
            (BindingContext as NewProjectConfigurationViewModel).ContinueCommand.Execute(newProjectConfig.DataObject);
        }

        void btnCancel_Clicked(System.Object sender, System.EventArgs e)
        {
            MainPage.Instance.ChangeScreen(new HomeView());
        }
    }
}