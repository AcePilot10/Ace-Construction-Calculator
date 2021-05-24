using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AceConstructionCalculator.HelpDesk;
using AceConstructionCalculator.Models;
using Xamarin.Forms;

namespace AceConstructionCalculator.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand HelpQuestionTappedCommand { get; set; }
        public ObservableCollection<QuestionAnswer> HelpDeskContent { get; set; } = new ObservableCollection<QuestionAnswer>();

        public MainPageViewModel()
        {
            HelpQuestionTappedCommand = new Command<QuestionAnswer>(HelpQuestionTapped);
        }

        public void LoadQuestionAnswers(ContentView screen)
        {
            HelpDeskContent.Clear();
            var content = HelpDeskInitiator.GetQuestionAnswers(screen.GetType());
            content.ForEach(x => HelpDeskContent.Add(x));
        }

        private void HelpQuestionTapped(QuestionAnswer tapped)
        {
            Application.Current.MainPage.DisplayAlert(tapped.Question, tapped.Answer, "Thanks!");
        }
    }
}