using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Configurations;
using WebApplication1.Models;

namespace WebApplication1.Databases
{
    public class PrepodDbContext : DbContext
    {
        DbSet<Prepod> Prepods { get; set; }

        DbSet<Cafedra> Cafedri { get; set; }
        Enum Subjects { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PrepodConfiguration());
            modelBuilder.ApplyConfiguration(new CafedraConfiguration());
            modelBuilder.ApplyConfiguration(new DegreeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }

        public PrepodDbContext(DbContextOptions<PrepodDbContext> options) : base(options) { }
    }
}
