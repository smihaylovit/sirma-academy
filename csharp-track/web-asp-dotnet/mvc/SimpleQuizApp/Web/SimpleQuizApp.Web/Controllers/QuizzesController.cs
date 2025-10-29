using Microsoft.AspNetCore.Mvc;
using SimpleQuizApp.Services.Data;

namespace SimpleQuizApp.Web.Controllers
{
    public class QuizzesController : Controller
    {
        private readonly IQuizzesService QuizzesService;

        public QuizzesController(IQuizzesService quizzesService)
        {
           QuizzesService = quizzesService;
        }

        public IActionResult List()
        {
            var quizzes = QuizzesService.GetAll();

            return View(quizzes);
        }
    }
}
