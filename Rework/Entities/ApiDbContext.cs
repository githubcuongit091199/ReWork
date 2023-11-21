using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure additional model constraints or relationships here if needed
        }
    }
}
