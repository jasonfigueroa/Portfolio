using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages.Blog
{
    public class ArticleModel : PageModel
    {
        private readonly ILogger<ArticleModel> _logger;
        private IMockArticleRepository _articleRepository;

        public Article Article { get; set; }

        public ArticleModel(ILogger<ArticleModel> logger, IMockArticleRepository articleRepository)
        {
            _logger = logger;
            _articleRepository = articleRepository;
        }
        
        public IActionResult OnGet(int id)
        {
            Article = _articleRepository.GetById(id);

            if (Article == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
