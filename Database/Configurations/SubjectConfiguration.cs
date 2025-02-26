using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Databases.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "Subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable(TableName);
            builder.HasKey(s => s.SubjectId).HasName($"pk_{TableName}_subject_id");

            builder.Property(s => s.SubjectId)
                .ValueGeneratedOnAdd()
                .HasColumnName("subject_id")
                .HasComment("Идентификатор предмета");

            builder.Property(s => s.SubjectName)
                .IsRequired()
                .HasColumnName("c_subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название предмета");
        }
    }
}
