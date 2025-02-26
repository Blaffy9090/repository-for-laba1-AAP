using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Databases.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class ZanyatieConfiguration : IEntityTypeConfiguration<Zanyatie>
    {
        private const string TableName = "Zanyatie";

        public void Configure(EntityTypeBuilder<Zanyatie> builder)
        {
            builder.HasKey(p => p.ZanyatieId)
                .HasName($"pk_{TableName}_zanyatie_id");

            builder.Property(p => p.ZanyatieId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ZanyatieId)
                .HasColumnName("zanyatie_id")
                .HasComment("Идентификатор занятия(пары)");

            builder.Property(p => p.ZanyatieName)
                .IsRequired()
                .HasColumnName("c_zanyatie_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название пары");

        }
    }
}
