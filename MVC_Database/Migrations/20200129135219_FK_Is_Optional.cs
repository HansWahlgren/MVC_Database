using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Database.Migrations
{
    public partial class FK_Is_Optional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Courses_CourseForeignKey",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherForeignKey",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Courses_CourseForeignKey",
                table: "Assignments",
                column: "CourseForeignKey",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherForeignKey",
                table: "Courses",
                column: "TeacherForeignKey",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Courses_CourseForeignKey",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherForeignKey",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Courses_CourseForeignKey",
                table: "Assignments",
                column: "CourseForeignKey",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherForeignKey",
                table: "Courses",
                column: "TeacherForeignKey",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
