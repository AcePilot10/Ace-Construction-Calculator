using System;
using System.Collections.Generic;
using System.Linq;
using AceConstructionCalculator.Views;
using AceConstructionCalculator.Views.Creation;

namespace AceConstructionCalculator.HelpDesk
{
    public static class HelpDeskInitiator
    {
        private static Type[] screenTypes = new Type[]
        {
            typeof(HomeView),
            typeof(AllProjectsView),
            typeof(NewProjectConfiguration),
            typeof(PricingConfigFrame),
            typeof(ProjectResult)
        };

        public static List<QuestionAnswer> QuestionAnswerContent { get; set; } = new List<QuestionAnswer>();

        public static void LoadContent()
        {
            foreach(var screen in screenTypes)
            {
                if(screen == typeof(HomeView))
                {
                    QuestionAnswer content1 = new QuestionAnswer()
                    {
                        Question = "What do I do?",
                        Answer = Answers.HOME_HELP,
                        ScreenType = typeof(HomeView)
                    };

                    QuestionAnswer content2 = new QuestionAnswer()
                    {
                        Question = "How do I create a new project?",
                        Answer = Answers.HOME_CREATE_NEW_PROJECT,
                        ScreenType = typeof(HomeView)
                    };

                    QuestionAnswerContent.Add(content1);
                    QuestionAnswerContent.Add(content2);
                }

                else if(screen == typeof(AllProjectsView))
                {
                    QuestionAnswer content1 = new QuestionAnswer()
                    {
                        Question = "What do I do?",
                        Answer = Answers.ALL_PROJECTS_HELP,
                        ScreenType = typeof(AllProjectsView)
                    };

                    QuestionAnswer content2 = new QuestionAnswer()
                    {
                        Question = "How do I search?",
                        Answer = Answers.ALL_PROJECTS_SEARCH,
                        ScreenType = typeof(AllProjectsView)
                    };

                    QuestionAnswer content3 = new QuestionAnswer()
                    {
                        Question = "How do I delete a project?",
                        Answer = Answers.ALL_PROJECTS_DELETE,
                        ScreenType = typeof(AllProjectsView)
                    };

                    QuestionAnswerContent.Add(content1);
                    QuestionAnswerContent.Add(content2);
                    QuestionAnswerContent.Add(content3);
                }

                else if(screen == typeof(NewProjectConfiguration))
                {
                    QuestionAnswer content1 = new QuestionAnswer()
                    {
                        Question = "What do I do?",
                        Answer = Answers.PROJ_CONFIG_HELP,
                        ScreenType = typeof(NewProjectConfiguration)
                    };

                    QuestionAnswer content2 = new QuestionAnswer()
                    {
                        Question = "Why cant I proceed?",
                        Answer = Answers.PROJ_CONFIG_ERROR,
                        ScreenType = typeof(NewProjectConfiguration)
                    };

                    QuestionAnswerContent.Add(content1);
                    QuestionAnswerContent.Add(content2);
                }

                else if(screen == typeof(PricingConfigFrame))
                {
                    QuestionAnswer content1 = new QuestionAnswer()
                    {
                        Question = "What do I do?",
                        Answer = Answers.PRICE_CONFIG_HELP,
                        ScreenType = typeof(PricingConfigFrame)
                    };

                    QuestionAnswer content2 = new QuestionAnswer()
                    {
                        Question = "How does this form work?",
                        Answer = Answers.PRICE_CONFIG_FORM_HELP,
                        ScreenType = typeof(PricingConfigFrame)
                    };

                    QuestionAnswerContent.Add(content1);
                    QuestionAnswerContent.Add(content2);
                }

                else if(screen == typeof(ProjectResult))
                {
                    QuestionAnswer content1 = new QuestionAnswer()
                    {
                        Question = "What do I do?",
                        Answer = Answers.PROJECT_RESULTS_HELP,
                        ScreenType = typeof(ProjectResult)
                    };

                    QuestionAnswerContent.Add(content1);
                }
            }
        }

        public static List<QuestionAnswer> GetQuestionAnswers(Type screenType)
        {
            return QuestionAnswerContent.Where(x => x.ScreenType == screenType).ToList();
        }
    }
}