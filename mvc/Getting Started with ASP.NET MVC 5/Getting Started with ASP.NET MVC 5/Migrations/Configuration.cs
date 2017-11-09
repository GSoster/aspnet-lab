namespace Getting_Started_with_ASP.NET_MVC_5.Migrations
{
    using Getting_Started_with_ASP.NET_MVC_5.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Getting_Started_with_ASP.NET_MVC_5.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Getting_Started_with_ASP.NET_MVC_5.Models.MovieDBContext context)
        {
            //The first parameter passed to the AddOrUpdate method specifies
            //the property to use to check if a row already exists.
            context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Rating = "PG",
            Price = 7.99M
        },

         new Movie
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Rating = "PG",
             Price = 8.99M
         },

         new Movie
         {
             Title = "Ghostbusters 2",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             Rating = "PG",
             Price = 9.99M
         },

       new Movie
       {
           Title = "Rio Bravo",
           ReleaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Rating = "PG",
           Price = 3.99M
       }
   );
        }
    }
}
