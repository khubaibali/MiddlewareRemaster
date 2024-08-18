using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fieldmappingAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FieldMapping",
                columns: table => new
                {
                    ContactNMFLoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldMapping", x => new { x.ContactNMFLoId, x.Id });
                    table.ForeignKey(
                        name: "FK_FieldMapping_Contact_ContactNMFLoId",
                        column: x => x.ContactNMFLoId,
                        principalTable: "Contact",
                        principalColumn: "NMFLoId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FieldMapping");
        }
    }
}
