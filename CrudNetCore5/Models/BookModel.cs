using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is required")]
        [StringLength(50, ErrorMessage ="The {0} has to be less than {2} and more than {1} characters", MinimumLength = 3)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The description is required")]
        [StringLength(200, ErrorMessage = "The {0} has to be less than {2} and more than {1} characters", MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The release date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The price is required")]
        public int Price { get; set; }
    }
}
