using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Migrations
{
    public partial class Update8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignments_Students_StudentId",
                table: "CourseAssignments");

            migrationBuilder.DropIndex(
                name: "IX_CourseAssignments_StudentId",
                table: "CourseAssignments");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "CourseAssignments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "CourseAssignments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignments_StudentId",
                table: "CourseAssignments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignments_Students_StudentId",
                table: "CourseAssignments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
