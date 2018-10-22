using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesApplication.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DefaultConnection")
        {

        }
    }
}