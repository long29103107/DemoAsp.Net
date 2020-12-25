using Microsoft.EntityFrameworkCore.Migrations;

namespace DoanRapphim.Migrations
{
    public partial class update_rapchieuphim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "RapChieuPhim",
                newName: "ThanhPho");

            migrationBuilder.AddColumn<string>(
                name: "QuanHuyen",
                table: "RapChieuPhim",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuanHuyen",
                table: "RapChieuPhim");

            migrationBuilder.RenameColumn(
                name: "ThanhPho",
                table: "RapChieuPhim",
                newName: "DiaChi");
        }
    }
}
