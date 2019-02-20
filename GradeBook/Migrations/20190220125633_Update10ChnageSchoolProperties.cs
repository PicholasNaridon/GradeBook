using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Migrations
{
    public partial class Update10ChnageSchoolProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Schools",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Schools",
                newName: "name");

            migrationBuilder.AlterColumn<int>(
                name: "Country",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
