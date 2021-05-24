using System;
using System.Windows.Input;
using AceConstructionCalculator.Models;
using AceConstructionCalculator.Views.Creation;
using Xamarin.Forms;

namespace AceConstructionCalculator.ViewModels.Creation
{
    public class NewProjectConfigurationViewModel : ViewModelBase
    {
        public ICommand ContinueCommand { get; private set; }

        public NewProjectConfigDataForm Form { get; set; }

        public NewProjectConfigurationViewModel()
        {
            ContinueCommand = new Command<NewProjectConfigDataForm>(Continue);
            // For debugging
            Form = new NewProjectConfigDataForm()
            {
                Name = "Test Project",
                AmountOfDoors = 5,
                Blocks = 15,
                LivingSquareFootage = 4000,
                TotalSquareFootage = 5000,
                SquareFootageOfBrickWork = 800,
                SquareFootageOfCeramicTile = 400,
                SquareFootageOfConcrete = 200,
                SquareFootageOfCountertops = 80,
                SquareFootageOfDriveway = 800,
                SquareFootageOfGarage = 800,
                SquareFootageOfRoof = 4500,
                SquareFootageOfServiceWalks = 2000,
                SquareFootageOfStoneWork = 200,
                SquareFootageOfStuccoArea = 200
            };
        }

        public NewProjectConfigurationViewModel(NewProjectConfigDataForm form)
        {
            Form = form;
            ContinueCommand = new Command<NewProjectConfigDataForm>(Continue);
        }

        private void Continue(NewProjectConfigDataForm projectData)
        {
            MainPage.Instance.ChangeScreen(new PricingConfigFrame(projectData));
        }
    }
}