using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Add_BaseObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseObjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    Rowversion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseObjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeObjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CreateDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeObjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypeObjects_BaseObjects_ID",
                        column: x => x.ID,
                        principalTable: "BaseObjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductObjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductObjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductObjects_TypeObjects_ID",
                        column: x => x.ID,
                        principalTable: "TypeObjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_ProductObjects_ID",
                        column: x => x.ID,
                        principalTable: "ProductObjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCosts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCosts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCosts_BaseObjects_ID",
                        column: x => x.ID,
                        principalTable: "BaseObjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCosts_ProductObjects_ProductID",
                        column: x => x.ProductID,
                        principalTable: "ProductObjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCosts_ProductID",
                table: "ProductCosts",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "ProductCosts");

            migrationBuilder.DropTable(
                name: "ProductObjects");

            migrationBuilder.DropTable(
                name: "TypeObjects");

            migrationBuilder.DropTable(
                name: "BaseObjects");
        }
    }
}
