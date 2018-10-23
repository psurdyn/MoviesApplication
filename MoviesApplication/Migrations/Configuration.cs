namespace MoviesApplication.Migrations
{
    using MoviesApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesApplication.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoviesApplication.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Genre genre = new Genre()
            {
                Name = "Science-Fiction"
            };

            Genre genre2 = new Genre()
            {
                Name = "Thriller"
            };

            Genre genre3 = new Genre()
            {
                Name = "Comedy"
            };

            context.Genres.Add(genre);
            context.Genres.Add(genre2);
            context.Genres.Add(genre3);

            context.SaveChanges();
        }
    }
}
