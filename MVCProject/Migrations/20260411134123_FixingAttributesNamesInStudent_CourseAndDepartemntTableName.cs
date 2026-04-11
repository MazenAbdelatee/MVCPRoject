using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProject.Migrations
{
    /// <inheritdoc />
    public partial class FixingAttributesNamesInStudent_CourseAndDepartemntTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Depatments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Depatments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Courses_CoursetId",
                table: "Students_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Depatments_DepartmentId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depatments",
                table: "Depatments");

            migrationBuilder.RenameTable(
                name: "Depatments",
                newName: "Departments");

            migrationBuilder.RenameColumn(
                name: "CoursetId",
                table: "Students_Courses",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Courses_CoursetId",
                table: "Students_Courses",
                newName: "IX_Students_Courses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Courses_CourseId",
                table: "Students_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Courses_CourseId",
                table: "Students_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Depatments");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Students_Courses",
                newName: "CoursetId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Courses_CourseId",
                table: "Students_Courses",
                newName: "IX_Students_Courses_CoursetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depatments",
                table: "Depatments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Depatments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Depatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Depatments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Depatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Courses_CoursetId",
                table: "Students_Courses",
                column: "CoursetId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Depatments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Depatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
