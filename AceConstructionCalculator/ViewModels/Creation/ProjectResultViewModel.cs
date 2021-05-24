using System;
using System.Windows.Input;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Services;
using AceConstructionCalculator.Views;
using Xamarin.Forms;

namespace AceConstructionCalculator.ViewModels.Creation
{
    public class ProjectResultViewModel
    {
        public ProjectResultsModel Result { get; set; }
        public ICommand CompleteCommand { get; private set; }

        private Action _onComplete;

        public ProjectResultViewModel(ProjectResultsModel results)
        {
            Result = results;
            CompleteCommand = new Command(Complete);
        }

        public ProjectResultViewModel(ProjectResultsModel results, Action onComplete)
        {
            Result = results;
            CompleteCommand = new Command(Complete);
            _onComplete = onComplete;
        }

        private async void Complete()
        {
            if (_onComplete == null)
            {
                await DependencyService.Resolve<ISaveProject>().Save(Result);
                MainPage.Instance.ChangeScreen(new HomeView());
            }
            else
            {
                _onComplete.Invoke();
            }
        }
    }
}