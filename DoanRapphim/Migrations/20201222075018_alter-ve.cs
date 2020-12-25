using Microsoft.EntityFrameworkCore.Migrations;

namespace DoanRapphim.Migrations
{
    public partial class alterve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenRap",
                table: "Ve");

            migrationBuilder.AddColumn<int>(
                name: "IdPhim",
                table: "Ve",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRap",
                table: "Ve",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ve_IdPhim",
                table: "Ve",
                column: "IdPhim");

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_Phim_IdPhim",
                table: "Ve",
                column: "IdPhim",
                principalTable: "Phim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ve_Phim_IdPhim",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_IdPhim",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "IdPhim",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "IdRap",
                table: "Ve");

            migrationBuilder.AddColumn<string>(
                name: "TenRap",
                table: "Ve",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
