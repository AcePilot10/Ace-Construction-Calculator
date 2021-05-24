using System;
namespace AceConstructionCalculator.HelpDesk
{
    public class Answers
    {
        public const string HOME_HELP = "Welcome to Ace Construction Calculator! This is the home screen. From here, you can create a new project or view your previously created projects.";
        public const string HOME_CREATE_NEW_PROJECT = "To create a new project, simply tap the button and follow the on-screen guides";

        public const string ALL_PROJECTS_HELP = "This is where you can view all of your previously created projects. Tap any of your projects to view them in detail.";
        public const string ALL_PROJECTS_SEARCH = "To search for specific projects, you can use the search bar at the top of the page and type in the projects name.";
        public const string ALL_PROJECTS_DELETE = "To delete a project, just swipe right on it, and tap the 'delete' button.";

        public const string PROJ_CONFIG_HELP = "Before creating a new project, we need to collect some basic information. Please fill in all required fields and hit continue when you're ready.";
        public const string PROJ_CONFIG_ERROR = "You must fill in every field presented. Please be sure to scroll down to ensure you didn't miss any!";

        public const string PRICE_CONFIG_HELP = "Please enter the market value of each expense in the form on the screen";
        public const string PRICE_CONFIG_FORM_HELP = "The price config form consists of a list of expenses, comprised into three columns. 1) The expense 2) The market value 3) The variable." +
            "The variable is the method in which the price is to be calculated. For example, a houses roof trussles would be configured by entering the price per square foot of roof trussle";

        public const string PROJECT_RESULTS_HELP = "These are the results of your project. You can view information such as subtotals, category breakdown, and a grand-total.";
    }
}