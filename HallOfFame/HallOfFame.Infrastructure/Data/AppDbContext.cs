using HallOfFame.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HallOfFame.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
