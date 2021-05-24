using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Services;
using AceConstructionCalculator.Views;
using Xamarin.Forms;

namespace AceConstructionCalculator.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<ProjectResultsModel> RecentProjects { get; private set; } = new ObservableCollection<ProjectResultsModel>();
        public ICommand ViewAllProjectsCommand { get; private set; }

        private bool _isLoading = true;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        private bool _hasSavedProjects = true;
        public bool HasSavedProjects
        {
            get
            {
                return _hasSavedProjects;
            }
            set
            {
                _hasSavedProjects = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            ViewAllProjectsCommand = new Command(ViewAllProjects);
            LoadLatestProjects();
        }
            
        private void ViewAllProjects()
        {
            MainPage.Instance.ChangeScreen(new AllProjectsView());
        }

        private async void LoadLatestProjects()
        {
            var savedProjects = await DependencyService.Resolve<ISaveProject>().LoadResults();
            var projects = savedProjects.ToList();
            if (projects.Count() == 0 || !projects.Any(x => x.CreationDate != null))
            {
                HasSavedProjects = false;
            }
            else
            {
                var projectsByDate = projects.OrderBy(x => x.CreationDate);
                var mostRecentProjects = projectsByDate.Take(3);
                mostRecentProjects.ToList().ForEach(x => RecentProjects.Add(x));
            }
            IsLoading = false;
        }
    }
}
