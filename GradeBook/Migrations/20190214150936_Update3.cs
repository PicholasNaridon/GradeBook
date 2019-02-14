using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "StudentCourses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "StudentCourses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentCourses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "StudentCourses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Courses");
        }
    }
}
