using SimpleQuizApp.Data.Models;

namespace SimpleQuizApp.Services.Data
{
    public interface IQuizService
    {
        IEnumerable<Quiz> GetAll();
        Quiz? GetById(string id);
        void Update(Quiz quiz);
    }
}
