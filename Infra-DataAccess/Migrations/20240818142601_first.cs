using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adapter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adapter", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsOnPremise = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "AdapterMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdapterMethod", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_AdapterMethod_Adapter_AdapterId",
                        column: x => x.AdapterId,
                        principalTable: "Adapter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdapterParam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UiName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    AdapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdapterParam", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_AdapterParam_Adapter_AdapterId",
                        column: x => x.AdapterId,
                        principalTable: "Adapter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    NMFLoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveySendOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.NMFLoId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Contact_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAdapter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerAdapterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CustomerAdapter_Adapter_AdapterId",
                        column: x => x.AdapterId,
                        principalTable: "Adapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAdapter_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAdapter_Customer_Id",
                        column: x => x.Id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAdapterParam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAdapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAdapterParam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAdapterParam_CustomerAdapter_CustomerAdapterId",
                        column: x => x.CustomerAdapterId,
                        principalTable: "CustomerAdapter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adapter_Name_Code",
                table: "Adapter",
                columns: new[] { "Name", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdapterMethod_AdapterId",
                table: "AdapterMethod",
                column: "AdapterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdapterParam_AdapterId",
                table: "AdapterParam",
                column: "AdapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomerId",
                table: "Contact",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdapter_AdapterId",
                table: "CustomerAdapter",
                column: "AdapterId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdapter_CustomerId",
                table: "CustomerAdapter",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdapterParam_CustomerAdapterId",
                table: "CustomerAdapterParam",
                column: "CustomerAdapterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdapterMethod");

            migrationBuilder.DropTable(
                name: "AdapterParam");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "CustomerAdapterParam");

            migrationBuilder.DropTable(
                name: "CustomerAdapter");

            migrationBuilder.DropTable(
                name: "Adapter");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
