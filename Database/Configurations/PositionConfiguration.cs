using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Databases.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        private const string TableName = "Position";

        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(p => p.PositionId)
                .HasName($"pk_{TableName}_position_id");

            builder.Property(p => p.PositionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("position_id")
                .HasComment("Идентификатор должности");

            builder.Property(p => p.PositionName)
                .IsRequired()
                .HasColumnName("c_position_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название должности (например, доцент)");
        }
    }
}
