using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreMVCIntro.Models
{
    public class Tutorial
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Article> Articles { get; set; }
    }
}
