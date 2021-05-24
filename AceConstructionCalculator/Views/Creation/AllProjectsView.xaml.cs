using System;
using System.Collections.Generic;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.ViewModels;
using Xamarin.Forms;

namespace AceConstructionCalculator.Views
{
    public partial class AllProjectsView : ContentView
    {
        private ProjectResultsModel _currentlySwipedProject;

        public AllProjectsView()
        {
            InitializeComponent();
        }

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            (BindingContext as AllProjectsViewModel).Query();
        }

        void SfListView_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            ProjectResultsModel result = e.ItemData as ProjectResultsModel;
            (BindingContext as AllProjectsViewModel).ItemTappedCommand.Execute(result);
        }

        void btnDelete_Clicked(System.Object sender, System.EventArgs e)
        {
            popupLayout.Show();
        }

        void ConfirmDelete_Clicked(System.Object sender, System.EventArgs e)
        {
            (BindingContext as AllProjectsViewModel).DeleteProjectCommand.Execute(_currentlySwipedProject);
        }

        void cancelDelete_Clicked(System.Object sender, System.EventArgs e)
        {
            popupLayout.Dismiss();
        }

        void listProjects_SwipeStarted(System.Object sender, Syncfusion.ListView.XForms.SwipeStartedEventArgs e)
        {
            _currentlySwipedProject = e.ItemData as ProjectResultsModel;
        }
    }
}