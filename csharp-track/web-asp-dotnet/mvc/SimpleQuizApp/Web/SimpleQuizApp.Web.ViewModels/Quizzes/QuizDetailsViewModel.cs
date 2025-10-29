using SimpleQuizApp.Web.ViewModels.Questions;

namespace SimpleQuizApp.Web.ViewModels.Quizzes
{
    public class QuizDetailsViewModel
    {
        public required QuizListItemViewModel QuizData { get; set; }
        public required List<QuestionViewModel> Questions { get; set; }
        public bool IsRetake { get; set; }
        public bool IsEvaluate { get; set; }
        public int TotalPoints
        {
            get
            {
                return Questions.Where(q => q.IsCorrect).Sum(q => q.Points);
            }
        }
    }
}
