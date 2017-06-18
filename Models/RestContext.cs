using Microsoft.EntityFrameworkCore;
 
namespace RESTauranter.Models
{
    public class RestContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public RestContext(DbContextOptions<RestContext> options) : base(options) { }

        public DbSet<Review> rest { get; set; }
        //rest should match the name of the table in the database
        //Review should match with our class in the Rest.cs
    }
}
