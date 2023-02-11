using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages.Blog
{
    public class ArticlesModel : PageModel
    {
        private readonly ILogger<ArticlesModel> _logger;
        private IMockArticleRepository _articleRepository;

        public List<Article> Articles { get; set; }

        public ArticlesModel(ILogger<ArticlesModel> logger, IMockArticleRepository articleRepository)
        {
            _logger = logger;
            _articleRepository = articleRepository;
        }

        public void OnGet()
        {
            Articles = _articleRepository.GetAll();
        }
    }
}
