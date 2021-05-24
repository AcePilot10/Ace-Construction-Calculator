using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Services;
using AceConstructionCalculator.Views;
using AceConstructionCalculator.Views.Creation;
using Syncfusion.Data.Extensions;
using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms;

namespace AceConstructionCalculator.ViewModels
{
    public class AllProjectsViewModel : ViewModelBase
    {
        public ObservableCollection<ProjectResultsModel> Projects { get; set; } = new ObservableCollection<ProjectResultsModel>();
        public ICommand BackCommand { get; private set; }
        public string SearchQuery { get; set; } = "";
        public ICommand ItemTappedCommand { get; private set; }
        public ICommand DeleteProjectCommand { get; private set; }

        private IEnumerable<ProjectResultsModel> _allProjects;

        public AllProjectsViewModel()
        {
            BackCommand = new Command(Back);
            ItemTappedCommand = new Command<ProjectResultsModel>(ItemTapped);
            DeleteProjectCommand = new Command<ProjectResultsModel>(DeleteProject);
        }

        private async void DeleteProject(ProjectResultsModel project)
        {
            var fileService = DependencyService.Resolve<ISaveProject>();
            await fileService.DeleteProject(project);
            var projects = await fileService.LoadResults();
            if(projects.ToList().Count() == 0)
            {
                MainPage.Instance.ChangeScreen(new HomeView());
            }
            else
            {
                LoadProjects();
            }
        }

        private void ItemTapped(ProjectResultsModel result)
        {
            Action onReturn = () =>
            {
                AllProjectsView view = new AllProjectsView();
                MainPage.Instance.ChangeScreen(view);
            };
            MainPage.Instance.ChangeScreen(new ProjectResult(result as ProjectResultsModel, onReturn));
        }

        private async void LoadProjects()
        {
            Projects.Clear();
            var projects = await DependencyService.Resolve<ISaveProject>().LoadResults();
            projects.ForEach(x => Projects.Add(x));
            _allProjects = projects;
        }

        public void Query()
        {
            if (SearchQuery.Length == 0)
            {
                LoadProjects();
                return;
            }
            List<ProjectResultsModel> filtered = new List<ProjectResultsModel>();
            foreach(var project in _allProjects)
            {
                if(project.Name.ToLower().Contains(SearchQuery.ToLower()))
                {
                    filtered.Add(project);
                }
            }
            Projects.Clear();
            filtered.ForEach(x => Projects.Add(x));
        }

        private void Back()
        {
            MainPage.Instance.ChangeScreen(new HomeView());
        }
    }
}