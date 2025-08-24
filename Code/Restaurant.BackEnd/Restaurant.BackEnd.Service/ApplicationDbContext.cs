using Microsoft.EntityFrameworkCore;

namespace Restaurant.BackEnd.Service
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor to pass the DbContextoptions to the base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets represent tables in database
    }
}