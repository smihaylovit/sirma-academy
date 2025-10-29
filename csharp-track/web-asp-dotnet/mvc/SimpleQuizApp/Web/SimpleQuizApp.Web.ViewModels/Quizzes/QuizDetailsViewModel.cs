using SimpleQuizApp.Web.ViewModels.Questions;

namespace SimpleQuizApp.Web.ViewModels.Quizzes
{
    public class QuizDetailsViewModel
    {
        public required QuizListItemViewModel QuizData { get; set; }
        public required List<QuestionViewModel> Questions { get; set; }
        public bool IsRetake { get; set; }
    }
}
