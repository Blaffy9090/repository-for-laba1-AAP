using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Configurations;
using WebApplication1.Models;

namespace WebApplication1.Databases
{
    public class PrepodDbContext : DbContext
    {
        DbSet<Prepod> Prepods { get; set; }

        DbSet<Cafedra> Cafedri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PrepodConfiguration());
            modelBuilder.ApplyConfiguration(new CafedraConfiguration());
        }

        public PrepodDbContext(DbContextOptions<PrepodDbContext> options) : base(options) { }
    }
}
