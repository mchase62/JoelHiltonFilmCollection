using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int FormId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required(ErrorMessage ="Choose a rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        // Build Foreign Key Relationship
        [Required(ErrorMessage ="Choose a category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
