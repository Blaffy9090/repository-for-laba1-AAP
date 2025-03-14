﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Databases.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class DegreeConfiguration : IEntityTypeConfiguration<Degree>
    {
        private const string TableName = "Degree";

        public void Configure(EntityTypeBuilder<Degree> builder)
        {
            builder.HasKey(p => p.DegreeId)
                .HasName($"pk_{TableName}_degree_id");

            builder.Property(p => p.DegreeId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DegreeId)
                .HasColumnName("c_degree_id")
                .HasComment("Bltynbabrfnjh cntgtyb");

            builder.Property(p => p.DegreeName)
                .IsRequired()
                .HasColumnName("c_degree_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название степени (например, кандидат наук)");

        }
    }
}
