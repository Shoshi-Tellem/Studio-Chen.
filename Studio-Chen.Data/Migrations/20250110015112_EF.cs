using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class EF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gymnasts_Courses_CourseId",
                table: "Gymnasts");

            migrationBuilder.DropIndex(
                name: "IX_Gymnasts_CourseId",
                table: "Gymnasts");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Gymnasts");

            migrationBuilder.CreateTable(
                name: "CourseGymnast",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    GymnastsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGymnast", x => new { x.CoursesId, x.GymnastsId });
                    table.ForeignKey(
                        name: "FK_CourseGymnast_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseGymnast_Gymnasts_GymnastsId",
                        column: x => x.GymnastsId,
                        principalTable: "Gymnasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGymnast_GymnastsId",
                table: "CourseGymnast",
                column: "GymnastsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "CourseGymnast");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Gymnasts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gymnasts_CourseId",
                table: "Gymnasts",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gymnasts_Courses_CourseId",
                table: "Gymnasts",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
