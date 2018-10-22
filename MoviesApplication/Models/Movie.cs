using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoviesApplication.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public DateTime ReleasedDate { get; set; }
        public Genre Genre { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
    }
}