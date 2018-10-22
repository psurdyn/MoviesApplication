using MoviesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApplication.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}