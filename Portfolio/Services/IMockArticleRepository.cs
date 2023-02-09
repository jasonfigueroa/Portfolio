using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IMockArticleRepository
    {
        // GetById
        Article GetById(int id);

        // GetAll
        List<Article> GetAll();
    }
}
