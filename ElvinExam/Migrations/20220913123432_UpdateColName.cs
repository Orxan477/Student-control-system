using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElvinExam.Migrations
{
    public partial class UpdateColName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paids_Subjects_SubjectsId",
                table: "Paids");

            migrationBuilder.RenameColumn(
                name: "SubjectsId",
                table: "Paids",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Paids_SubjectsId",
                table: "Paids",
                newName: "IX_Paids_SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paids_Subjects_SubjectId",
                table: "Paids",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paids_Subjects_SubjectId",
                table: "Paids");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Paids",
                newName: "SubjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Paids_SubjectId",
                table: "Paids",
                newName: "IX_Paids_SubjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paids_Subjects_SubjectsId",
                table: "Paids",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
