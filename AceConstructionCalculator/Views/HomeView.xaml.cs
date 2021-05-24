using System;
using System.Collections.Generic;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Views.Creation;
using Xamarin.Forms;

namespace AceConstructionCalculator.Views
{
    public partial class HomeView : ContentView
    {
        public HomeView()
        {
            InitializeComponent();
        }

        void SfButton_Clicked(System.Object sender, System.EventArgs e)
        {
            MainPage.Instance.ChangeScreen(new NewProjectConfiguration());
        }

        void listRecentProjects_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var project = e.ItemData as ProjectResultsModel;
            Action onReturn = () =>
            {
                MainPage.Instance.ChangeScreen(new HomeView());
            };
            MainPage.Instance.ChangeScreen(new ProjectResult(project, onReturn));
            listRecentProjects.SelectedItem = null;
        }
    }
}
