using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);

        Article UpdateArticle(Article article);

        Article DeleteArticle(int Id);

        Article GetArticle(int Id);

        IEnumerable<Article> GetAllArticle();

        IEnumerable<Article> GetArticlesByTutorialId(int tutorialId);
    }
}
