using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        Article AddArticle(Article article);

        Article UpdateArticle(Article article);

        Article DeleteArticle(int Id);

        Article GetArticle(int Id);

        IEnumerable<Article> GetAllArticle();

        IEnumerable<Article> GetArticlesByTutorialId(int tutorialId);
    }
}
