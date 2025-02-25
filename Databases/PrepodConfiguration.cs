using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using WebApplication1.Databases.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Databases
{
    public class PrepodConfiguration : IEntityTypeConfiguration<Prepod>
    {
        private const string TableName = "Prepod";

        public void Configure(EntityTypeBuilder<Prepod> builder)
        {
            builder.HasKey(p => p.PrepodId)
                .HasName($"pk_{TableName}_prepod_id");

            builder.Property(p => p.PrepodId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.PrepodId)
                .HasColumnName("prepod_id")
                .HasComment("Идентификатор препода");

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("c_prepod_firstname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Имя препода");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("c_prepod_lastname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Фамилия препода");

            builder.Property(p => p.MiddleName)
                .HasColumnName("c_prepod_midname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Отчество препода");

            builder.Property(p => p.CafedraId)
                .IsRequired()
                .HasColumnName("c_cafedra_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("Айди кафедры");

        }
    }
}
