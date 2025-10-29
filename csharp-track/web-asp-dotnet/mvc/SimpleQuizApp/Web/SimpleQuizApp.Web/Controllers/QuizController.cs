using Microsoft.AspNetCore.Mvc;
using SimpleQuizApp.Services.Data;
using SimpleQuizApp.Web.ViewModels.Questions;
using SimpleQuizApp.Web.ViewModels.Quizzes;

namespace SimpleQuizApp.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizzesService)
        {
            _quizService = quizzesService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var quizzes = _quizService.GetAll();
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
        public IActionResult Details(string id, bool isRetake = false, bool isEvaluate = false)
        {
            var quiz = _quizService.GetById(id);

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
                IsRetake = isRetake,
                IsEvaluate = isEvaluate,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Submit(string id, QuizDetailsViewModel model)
        {
            var quiz = _quizService.GetById(id);

            if (quiz == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Details", new { id = quiz.Id, isRetake = true });
            }

            foreach (var qvm in model.Questions)
            {
                var q = quiz.Questions.FirstOrDefault(x => x.Id == qvm.Id);
                
                if (q != null)
                {
                    q.SelectedOption = qvm.SelectedOption;
                }
            }

            return RedirectToAction("Details", new { id = quiz.Id, isRetake = false, isEvaluate = true });
        }
    }
}
