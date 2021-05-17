using Microsoft.EntityFrameworkCore;

namespace PortfolioProject.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        public DbSet<Project> Projects { get; set; }

    }
}