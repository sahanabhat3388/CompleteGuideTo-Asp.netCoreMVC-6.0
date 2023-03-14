using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;
using Microsoft.EntityFrameworkCore;

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
            var newArticle = new Article()
            {
                ArticleTitle = article.ArticleTitle,
                ArticleContent = article.ArticleContent,
                TutorialId = article.TutorialId
            };
            _context.Articles.AddAsync(newArticle);
            _context.SaveChangesAsync();
        }

        public async Task<Article> DeleteArticle(int Id)
        {
            Article article = await _context.Articles.FindAsync(Id);
            if (article != null)
            {
                _context.Articles.Remove(article);
            }
            return article;
        }

        public async Task<IEnumerable<Article>> GetAllArticle()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<IEnumerable<Tutorial>> GetAllTutorials()
        {
            return await _context.Tutorials.ToListAsync();
        }

        public async Task<Article> GetArticleById(int Id)
        {
            return await _context.Articles.FindAsync(Id);
        }

        public async Task<IEnumerable<Article>> GetArticlesByTutorialId(int tutorialId)
        {
            return await _context.Articles.Where(a => a.TutorialId == tutorialId).ToListAsync();
        }

        public void UpdateArticle(Article articleModified)
        {
            _context.Articles.Update(articleModified);
        }
    }
}
