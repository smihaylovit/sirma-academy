using SimpleQuizApp.Data.Models;

namespace SimpleQuizApp.Services.Data
{
    public interface IQuizzesService
    {
        IEnumerable<Quiz> GetAll();
        Quiz? GetById(string id);
        //void Create(Quiz quiz);
        //void Update(Quiz quiz);
        //void Delete(string id);
    }
}
