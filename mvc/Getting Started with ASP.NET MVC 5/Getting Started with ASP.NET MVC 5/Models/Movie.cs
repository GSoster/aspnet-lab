using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Getting_Started_with_ASP.NET_MVC_5.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")] //The Display attribute specifies what to display for the name of a field
        [DataType(DataType.Date)] //The DataType attribute specifies the type of the data, in this case it's a date (time info will not be displayed)
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] //The DisplayFormat attribute is needed for a bug in the Chrome browser that renders date formats incorrectly
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}