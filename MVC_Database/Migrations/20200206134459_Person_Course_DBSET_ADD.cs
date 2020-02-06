using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Database.Migrations
{
    public partial class Person_Course_DBSET_ADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonCourse_Courses_CourseId",
                table: "PersonCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonCourse_Students_StudentId",
                table: "PersonCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonCourse",
                table: "PersonCourse");

            migrationBuilder.RenameTable(
                name: "PersonCourse",
                newName: "PersonCourses");

            migrationBuilder.RenameIndex(
                name: "IX_PersonCourse_CourseId",
                table: "PersonCourses",
                newName: "IX_PersonCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCourses",
                table: "PersonCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCourses_Courses_CourseId",
                table: "PersonCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCourses_Students_StudentId",
                table: "PersonCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonCourses_Courses_CourseId",
                table: "PersonCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonCourses_Students_StudentId",
                table: "PersonCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonCourses",
                table: "PersonCourses");

            migrationBuilder.RenameTable(
                name: "PersonCourses",
                newName: "PersonCourse");

            migrationBuilder.RenameIndex(
                name: "IX_PersonCourses_CourseId",
                table: "PersonCourse",
                newName: "IX_PersonCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCourse",
                table: "PersonCourse",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCourse_Courses_CourseId",
                table: "PersonCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCourse_Students_StudentId",
                table: "PersonCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
