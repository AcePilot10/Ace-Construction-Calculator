using System;
using System.Collections.Generic;
using AceConstructionCalculator.HelpDesk;
using AceConstructionCalculator.ViewModels;
using AceConstructionCalculator.Views;
using Xamarin.Forms;

namespace AceConstructionCalculator
{
    public partial class MainPage : ContentPage
    {
        public static MainPage Instance { get; private set; }

        private ContentView _currentScreen;

        public MainPage()
        {
            Instance = this;
            InitializeComponent();
            (BindingContext as MainPageViewModel).LoadQuestionAnswers(new HomeView());
        }

        void btnHelp_Clicked(System.Object sender, System.EventArgs e)
        {
            popupLayout.Show(true);
        }

        public void ChangeScreen(ContentView view)
        {
            ContentContainer.Children.Clear();
            view.HorizontalOptions = LayoutOptions.FillAndExpand;
            view.VerticalOptions = LayoutOptions.FillAndExpand;
            ContentContainer.Children.Add(view);
            (BindingContext as MainPageViewModel).LoadQuestionAnswers(view);
        }

        public View GetCurrentScreen()
        {
            return _currentScreen;
        }

        void listQuestions_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            (BindingContext as MainPageViewModel).HelpQuestionTappedCommand.Execute(e.ItemData as QuestionAnswer);
            //listQuestions.SelectedItem = null;
        }
    }
}