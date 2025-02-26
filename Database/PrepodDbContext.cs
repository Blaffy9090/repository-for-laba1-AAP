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
        DbSet<Zanyatie> Zanyatiya { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PrepodConfiguration());
            modelBuilder.ApplyConfiguration(new CafedraConfiguration());
            modelBuilder.ApplyConfiguration(new DegreeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new ZanyatieConfiguration());
        }

        public PrepodDbContext(DbContextOptions<PrepodDbContext> options) : base(options) { }
    }
}
