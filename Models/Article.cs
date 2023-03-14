
namespace Asp.netCoreMVCIntro.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }

        //Setup relationship with Tutorial model/table        
        public int TutorialId { get; set; } //Foreign Key
        public Tutorial Tutorial { get; set; } //Reference navigaton property
    }
}
