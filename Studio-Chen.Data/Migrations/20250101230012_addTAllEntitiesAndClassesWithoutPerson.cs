using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTAllEntitiesAndClassesWithoutPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_people_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_people_Addresses_AddressId",
                table: "people");

            migrationBuilder.DropForeignKey(
                name: "FK_people_Courses_CourseId",
                table: "people");

            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                table: "people");

            migrationBuilder.DropIndex(
                name: "IX_people_CourseId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "people");

            migrationBuilder.RenameTable(
                name: "people",
                newName: "Teachers");

            migrationBuilder.RenameIndex(
                name: "IX_people_AddressId",
                table: "Teachers",
                newName: "IX_Teachers_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Gymnasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gymnasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gymnasts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gymnasts_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gymnasts_AddressId",
                table: "Gymnasts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Gymnasts_CourseId",
                table: "Gymnasts",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Addresses_AddressId",
                table: "Teachers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Addresses_AddressId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Gymnasts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "people");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_AddressId",
                table: "people",
                newName: "IX_people_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "people",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "people",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                table: "people",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_people_CourseId",
                table: "people",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_people_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "people",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_people_Addresses_AddressId",
                table: "people",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_people_Courses_CourseId",
                table: "people",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
