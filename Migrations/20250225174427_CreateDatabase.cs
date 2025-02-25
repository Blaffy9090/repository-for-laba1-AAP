using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cafedri",
                columns: table => new
                {
                    cafedra_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор кафедры")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_prepod_cafedraname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Имя кафедры")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Cafedra_cafedra_id", x => x.cafedra_id);
                });

            migrationBuilder.CreateTable(
                name: "Prepod",
                columns: table => new
                {
                    prepod_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор препода")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_prepod_firstname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Имя препода"),
                    c_prepod_lastname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Фамилия препода"),
                    c_prepod_midname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Отчество препода"),
                    c_cafedra_id = table.Column<int>(type: "int", nullable: false, comment: "Айди кафедры")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Prepod_prepod_id", x => x.prepod_id);
                    table.ForeignKey(
                        name: "fk_f_group_id",
                        column: x => x.c_cafedra_id,
                        principalTable: "Cafedri",
                        principalColumn: "cafedra_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_Prepod_fk_f_group_id",
                table: "Prepod",
                column: "c_cafedra_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prepod");

            migrationBuilder.DropTable(
                name: "Cafedri");
        }
    }
}
