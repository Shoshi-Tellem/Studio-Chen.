using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class change_identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Teacher_TeacherIdentity",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Gymnast_courses_CourseIdentity",
                table: "Gymnast");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Teacher",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CourseIdentity",
                table: "Gymnast",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Gymnast",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Gymnast_CourseIdentity",
                table: "Gymnast",
                newName: "IX_Gymnast_CourseId");

            migrationBuilder.RenameColumn(
                name: "TeacherIdentity",
                table: "courses",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "courses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_courses_TeacherIdentity",
                table: "courses",
                newName: "IX_courses_TeacherId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Address",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Teacher_TeacherId",
                table: "courses",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gymnast_courses_CourseId",
                table: "Gymnast",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Teacher_TeacherId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Gymnast_courses_CourseId",
                table: "Gymnast");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teacher",
                newName: "Identity");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Gymnast",
                newName: "CourseIdentity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Gymnast",
                newName: "Identity");

            migrationBuilder.RenameIndex(
                name: "IX_Gymnast_CourseId",
                table: "Gymnast",
                newName: "IX_Gymnast_CourseIdentity");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "courses",
                newName: "TeacherIdentity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "courses",
                newName: "Identity");

            migrationBuilder.RenameIndex(
                name: "IX_courses_TeacherId",
                table: "courses",
                newName: "IX_courses_TeacherIdentity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Address",
                newName: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Teacher_TeacherIdentity",
                table: "courses",
                column: "TeacherIdentity",
                principalTable: "Teacher",
                principalColumn: "Identity",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gymnast_courses_CourseIdentity",
                table: "Gymnast",
                column: "CourseIdentity",
                principalTable: "courses",
                principalColumn: "Identity");
        }
    }
}
