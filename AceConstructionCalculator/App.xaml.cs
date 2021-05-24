using System;
using AceConstructionCalculator.HelpDesk;
using AceConstructionCalculator.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AceConstructionCalculator
{
    public partial class App : Application
    {

        public App()
        {
            HelpDeskInitiator.LoadContent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQ3NDUxQDMxMzkyZTMxMmUzMEppN2YrcE1YSXgwTFRvMDBUR1RHZjl0VWlrbkM0OXlCcW5VSFRNRktsbEk9");
            InitializeComponent();
            var saveProjectService = new SaveProjectService();
            //saveProjectService.DeleteAll();
            DependencyService.Register<ISaveProject, SaveProjectService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
