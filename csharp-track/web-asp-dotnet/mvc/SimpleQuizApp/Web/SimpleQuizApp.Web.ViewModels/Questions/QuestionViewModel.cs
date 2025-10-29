namespace SimpleQuizApp.Web.ViewModels.Questions
{
    public class QuestionViewModel
    {
        public required string Id { get; set; }
        public required string Text { get; set; }
        public int Points { get; set; }
        public required Dictionary<string, bool> Options { get; set; }
        public string? SelectedOption { get; set; }
        public bool IsCorrect
        {
            get
            {
                if (SelectedOption == null)
                {
                    return false;
                }

                return Options.TryGetValue(SelectedOption, out bool isCorrect) && isCorrect;
            }
        }
    }
}
