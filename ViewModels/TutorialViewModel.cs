using Asp.netCoreMVCIntro.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Asp.netCoreMVCIntro.ViewModels
{
    public class TutorialViewModel    {
        //public Tutorial tutorial { get; set; }
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Please enter text")]
        [Required]
        [Display(Name = "Enter the name of tutorial")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Please describe your tutorial")]
        public string Description { get; set; }
    }
}
