using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCosts_ProductObjects_ProductID",
                table: "ProductCosts");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductCosts",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCosts_ProductID",
                table: "ProductCosts",
                newName: "IX_ProductCosts_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "ProductObjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "ProductObjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "ProductObjects",
                type: "float",
                nullable: true,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductCosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Circulation",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPages",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOfPublishing",
                table: "Books",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCosts_ProductObjects_ProductId",
                table: "ProductCosts",
                column: "ProductId",
                principalTable: "ProductObjects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCosts_ProductObjects_ProductId",
                table: "ProductCosts");

            migrationBuilder.DropColumn(
                name: "Format",
                table: "ProductObjects");

            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "ProductObjects");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ProductObjects");

            migrationBuilder.DropColumn(
                name: "Circulation",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NumberOfPages",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "YearOfPublishing",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductCosts",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCosts_ProductId",
                table: "ProductCosts",
                newName: "IX_ProductCosts_ProductID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ProductCosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCosts_ProductObjects_ProductID",
                table: "ProductCosts",
                column: "ProductID",
                principalTable: "ProductObjects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
