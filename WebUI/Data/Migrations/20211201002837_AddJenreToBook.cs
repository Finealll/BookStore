using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddJenreToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JenreId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_JenreId",
                table: "Books",
                column: "JenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Jenres_JenreId",
                table: "Books",
                column: "JenreId",
                principalTable: "Jenres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Jenres_JenreId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_JenreId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "JenreId",
                table: "Books");
        }
    }
}
