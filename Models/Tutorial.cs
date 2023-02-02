using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreMVCIntro.Models
{
    public class Tutorial
    {
        public int Id { get; set; }        

        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Please enter text")]
        [Required]
        [Display(Name = "Tutorial Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tutorial Description")]
        public string Description { get; set; }

        public List<Article> Articles { get; set; }
    }
}
