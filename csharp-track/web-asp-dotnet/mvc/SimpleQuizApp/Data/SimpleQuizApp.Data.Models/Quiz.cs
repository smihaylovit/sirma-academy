namespace SimpleQuizApp.Data.Models
{
    public class Quiz
    {
        public Quiz()
        {
            Id = Guid.NewGuid().ToString();
            Questions = new HashSet<Question>();
        }

        public string Id { get; private set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public int? TimeLimit { get; set; }
        public ICollection<Question> Questions { get; private set; }
    }
}
