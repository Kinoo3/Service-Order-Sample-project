using Microsoft.EntityFrameworkCore;
using WebApi.Model.Entities;

namespace WebApi.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Entity1> Entity1s { get; set; }
        public DbSet<Entity2> Entity2s { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
