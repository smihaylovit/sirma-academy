using SimpleQuizApp.Data.Models;

namespace SimpleQuizApp.Services.Data
{
    public class QuizService : IQuizService
    {
        private static HashSet<Quiz> Quizzes =
        [
            new Quiz
            {
                Title = "MVC & Web Frameworks Sample Quiz",
                Description = "Basic multiple-choice questions about MVC and web frameworks.",
                TimeLimit = 10,
                Questions =
                {
                    new Question
                    {
                        Text = "Which annotation is used to define a controller in Spring MVC?",
                        Points = 5,
                        Options =
                        {
                            { "@Component", false },
                            { "@Controller", true },
                            { "@RestService", false },
                            { "@MVCController", false }
                        }
                    },
                    new Question
                    {
                        Text = "Which method in a controller returns a View in ASP.NET Core MVC?",
                        Points = 5,
                        Options =
                        {
                            { "Display()", false },
                            { "Show()", false },
                            { "View()", true },
                            { "Render()", false }
                        }
                    },
                    new Question
                    {
                        Text = "Which method is used to define a GET route in Express?",
                        Points = 5,
                        Options =
                        {
                            { "app.route()", false },
                            { "app.get()", true },
                            { "express.get()", false },
                            { "router.create()", false }
                        }
                    },
                    new Question
                    {
                        Text = "In MVC architecture, what does the 'C' stand for?",
                        Points = 5,
                        Options =
                        {
                            { "Code", false },
                            { "Controller", true },
                            { "Class", false },
                            { "Content", false }
                        }
                    },
                    new Question
                    {
                        Text = "Which part of MVC is responsible for handling user input?",
                        Points = 5,
                        Options =
                        {
                            { "Model", false },
                            { "View", false },
                            { "Controller", true },
                            { "Template", false }
                        }
                    }
                }
            }       
        ];

        public IEnumerable<Quiz> GetAll()
        {
            return Quizzes;
        }

        public Quiz? GetById(string id)
        {
            return Quizzes.SingleOrDefault(q => q.Id == id);
        }

        public void Update(Quiz quiz)
        {
            var oldQuiz = Quizzes.SingleOrDefault(q => q.Id == quiz.Id);
            oldQuiz = quiz;
        }
    }
}
