using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Movie
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Title", ResourceType = typeof(Resources.Pages.IndexModel))]
        [Required(
            ErrorMessageResourceName = nameof(Resources.Pages.IndexModel.TitleFieldIsRequired),
            ErrorMessageResourceType = typeof(Resources.Pages.IndexModel)
        )]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "ReleaseDate", ResourceType = typeof(Resources.Pages.IndexModel))]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre", ResourceType = typeof(Resources.Pages.IndexModel))]
        public string Genre { get; set; }
        [Display(Name = "Price", ResourceType = typeof(Resources.Pages.IndexModel))]
        public decimal Price { get; set; }
        [Display(Name = "Rating", ResourceType = typeof(Resources.Pages.IndexModel))]
        public string Rating { get; set; }
        [Display(Name = "Production", ResourceType = typeof(Resources.Pages.IndexModel))]
        public string Production { get; set; }
    }
}
