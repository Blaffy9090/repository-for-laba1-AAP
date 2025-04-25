using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Datqabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cafedra_c_admin_id",
                table: "Cafedra");

            migrationBuilder.CreateIndex(
                name: "IX_Cafedra_c_admin_id",
                table: "Cafedra",
                column: "c_admin_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cafedra_c_admin_id",
                table: "Cafedra");

            migrationBuilder.CreateIndex(
                name: "IX_Cafedra_c_admin_id",
                table: "Cafedra",
                column: "c_admin_id",
                unique: true);
        }
    }
}
