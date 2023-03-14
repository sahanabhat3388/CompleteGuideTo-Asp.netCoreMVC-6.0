using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDbContext _context;
        public ArticleRepository(TutorialDbContext context)
        {
            _context = context;
        }

        public void AddArticle(ArticleViewModel article)
        {
            throw new NotImplementedException();
        }

        public Article DeleteArticle(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticle()
        {
            return _context.Articles;
        }

        public Article GetArticle(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetArticlesByTutorialId(int tutorialId)
        {
            return _context.Articles.Where(a => a.TutorialId == tutorialId).ToList();
        }

        public Article UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
