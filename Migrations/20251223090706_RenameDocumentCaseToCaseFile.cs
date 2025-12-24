using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawOfficeManagement.Migrations
{
    /// <inheritdoc />
    public partial class RenameDocumentCaseToCaseFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_CaseFiles_CaseId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "Documents",
                newName: "CaseFileId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_CaseId",
                table: "Documents",
                newName: "IX_Documents_CaseFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_CaseFiles_CaseFileId",
                table: "Documents",
                column: "CaseFileId",
                principalTable: "CaseFiles",
                principalColumn: "CaseFileId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_CaseFiles_CaseFileId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "CaseFileId",
                table: "Documents",
                newName: "CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_CaseFileId",
                table: "Documents",
                newName: "IX_Documents_CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_CaseFiles_CaseId",
                table: "Documents",
                column: "CaseId",
                principalTable: "CaseFiles",
                principalColumn: "CaseFileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
