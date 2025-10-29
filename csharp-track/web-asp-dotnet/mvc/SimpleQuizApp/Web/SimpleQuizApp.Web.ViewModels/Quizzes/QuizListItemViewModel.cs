namespace SimpleQuizApp.Web.ViewModels.Quizzes
{
    public class QuizListItemViewModel
    {
        public required string Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public int? TimeLimit { get; set; }
    }
}
