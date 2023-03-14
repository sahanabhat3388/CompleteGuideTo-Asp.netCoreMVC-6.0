using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DisplayArticles(int id)
        {
            IEnumerable<Article> articles =await _articleRepository.GetArticlesByTutorialId(id);
            return View(articles);
        }
    }
}
