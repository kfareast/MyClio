using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawOfficeManagement.Migrations
{
    /// <inheritdoc />
    public partial class DeleteWorkLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkLogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkLogs",
                columns: table => new
                {
                    WorkLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLogs", x => x.WorkLogId);
                    table.ForeignKey(
                        name: "FK_WorkLogs_CaseFiles_CaseFileId",
                        column: x => x.CaseFileId,
                        principalTable: "CaseFiles",
                        principalColumn: "CaseFileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_CaseFileId",
                table: "WorkLogs",
                column: "CaseFileId");
        }
    }
}
