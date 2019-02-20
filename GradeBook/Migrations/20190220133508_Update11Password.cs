using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Migrations
{
    public partial class Update11Password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Teachers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Students",
                newName: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Teachers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Students",
                newName: "password");
        }
    }
}
