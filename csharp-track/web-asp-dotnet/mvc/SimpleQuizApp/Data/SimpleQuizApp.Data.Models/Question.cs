namespace SimpleQuizApp.Data.Models
{
    public class Question
    {
        public Question()
        {
            Id = Guid.NewGuid().ToString();
            Options = new Dictionary<string, bool>();
        }

        public string Id { get; private set; }
        public required string Text { get; set; }
        public int Points { get; set; }
        public IDictionary<string, bool> Options { get; private set; }
        public string? SelectedOption { get; set; }
    }
}
