using Microsoft.EntityFrameworkCore;

namespace Mission14API_olsenj8.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }
    }
}
