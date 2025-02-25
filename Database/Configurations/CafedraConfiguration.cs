using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Databases.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class CafedraConfiguration : IEntityTypeConfiguration<Cafedra>
    {
        private const string TableName = "Cafedra";

        public void Configure(EntityTypeBuilder<Cafedra> builder)
        {
            builder.HasKey(p => p.CafedraId)
                .HasName($"pk_{TableName}_cafedra_id");

            builder.Property(p => p.CafedraId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CafedraId)
                .HasColumnName("cafedra_id")
                .HasComment("Идентификатор кафедры");

            builder.Property(p => p.CafedraName)
                .IsRequired()
                .HasColumnName("c_prepod_cafedraname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Имя кафедры");

        }
    }
}
