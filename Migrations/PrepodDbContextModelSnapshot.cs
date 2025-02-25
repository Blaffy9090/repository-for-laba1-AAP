﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Databases;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(PrepodDbContext))]
    partial class PrepodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Cafedra", b =>
                {
                    b.Property<int>("CafedraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cafedra_id")
                        .HasComment("Идентификатор кафедры");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CafedraId"));

                    b.Property<string>("CafedraName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_prepod_cafedraname")
                        .HasComment("Имя кафедры");

                    b.HasKey("CafedraId")
                        .HasName("pk_Cafedra_cafedra_id");

                    b.ToTable("Cafedri");
                });

            modelBuilder.Entity("WebApplication1.Models.Prepod", b =>
                {
                    b.Property<int>("PrepodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prepod_id")
                        .HasComment("Идентификатор препода");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrepodId"));

                    b.Property<int>("CafedraId")
                        .HasColumnType("int4")
                        .HasColumnName("c_cafedra_id")
                        .HasComment("Айди кафедры");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_prepod_firstname")
                        .HasComment("Имя препода");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_prepod_lastname")
                        .HasComment("Фамилия препода");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_prepod_midname")
                        .HasComment("Отчество препода");

                    b.HasKey("PrepodId")
                        .HasName("pk_Prepod_prepod_id");

                    b.HasIndex(new[] { "CafedraId" }, "idx_Prepod_fk_f_group_id");

                    b.ToTable("Prepod", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Prepod", b =>
                {
                    b.HasOne("WebApplication1.Models.Cafedra", "Cafedra")
                        .WithMany()
                        .HasForeignKey("CafedraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_group_id");

                    b.Navigation("Cafedra");
                });
#pragma warning restore 612, 618
        }
    }
}
