using Microsoft.AspNetCore.Mvc;
using SimpleQuizApp.Services.Data;
using SimpleQuizApp.Web.ViewModels.Questions;
using SimpleQuizApp.Web.ViewModels.Quizzes;

namespace SimpleQuizApp.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizService QuizService;

        public QuizController(IQuizService quizzesService)
        {
            QuizService = quizzesService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var quizzes = QuizService.GetAll();
            var viewModel = new QuizListViewModel
            {
                Quizzes = quizzes.Select(q => new QuizListItemViewModel
                {
                    Id = q.Id,
                    Title = q.Title,
                    Description = q.Description,
                    TimeLimit = q.TimeLimit,
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(string id, bool isRetake = false)
        {
            var quiz = QuizService.GetById(id);

            if (quiz == null)
            {
                return NotFound();
            }

            var viewModel = new QuizDetailsViewModel
            {
                QuizData = new QuizListItemViewModel
                {
                    Id = quiz.Id,
                    Title = quiz.Title,
                    Description = quiz.Description,
                    TimeLimit = quiz.TimeLimit,
                },
                Questions = quiz.Questions.Select(q => new QuestionViewModel
                {
                    Id = q.Id,
                    Text = q.Text,
                    Points = q.Points,
                    Options = q.Options.ToDictionary(x => x.Key, x => x.Value),
                    SelectedOption = q.SelectedOption,
                }).ToList(),
                IsRetake = isRetake
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Submit(string id, QuizDetailsViewModel model)
        {
            var quiz = QuizService.GetById(id);

            if (quiz == null)
            {
                return NotFound();
            }

            //foreach (var question in quiz.Questions)
            //{
            //    if (answers.TryGetValue(question.Id, out var selectedOption))
            //    {
            //        question.SelectedOption = selectedOption;
            //    }
            //}

            QuizService.Update(quiz);

            return RedirectToAction("Details", new { id = quiz.Id });
        }
    }
}
