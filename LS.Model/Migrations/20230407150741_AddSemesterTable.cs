using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LS.Model.Migrations
{
    /// <inheritdoc />
    public partial class AddSemesterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SemesterID",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SemesterID",
                table: "Subject",
                column: "SemesterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Semester_SemesterID",
                table: "Subject",
                column: "SemesterID",
                principalTable: "Semester",
                principalColumn: "SemesterID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Semester_SemesterID",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SemesterID",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SemesterID",
                table: "Subject");
        }
    }
}
