using MoviesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApplication.Controllers
{
    public class MovieController : Controller
    {
        private MyDbContext _context;

        public MovieController()
        {
            _context = new MyDbContext();
        }

        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Movie movie )
        {
            

            return View();
        }
    }
}