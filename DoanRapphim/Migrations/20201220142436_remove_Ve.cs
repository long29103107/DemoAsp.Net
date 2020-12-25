using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoanRapphim.Migrations
{
    public partial class remove_Ve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ve_Ghe_IdGhe",
                table: "Ve");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "Ve");

            migrationBuilder.RenameColumn(
                name: "IdGhe",
                table: "Ve",
                newName: "IdPhong");

            migrationBuilder.RenameIndex(
                name: "IX_Ve_IdGhe",
                table: "Ve",
                newName: "IX_Ve_IdPhong");

            migrationBuilder.AddColumn<DateTime>(
                name: "GioChieu",
                table: "Ve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdLoaiGhe",
                table: "Ve",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayChieu",
                table: "Ve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "QuanHuyen",
                table: "Ve",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenGhe",
                table: "Ve",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenRap",
                table: "Ve",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThanhPho",
                table: "Ve",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ve_IdLoaiGhe",
                table: "Ve",
                column: "IdLoaiGhe");

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_LoaiGhe_IdLoaiGhe",
                table: "Ve",
                column: "IdLoaiGhe",
                principalTable: "LoaiGhe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_Phong_IdPhong",
                table: "Ve",
                column: "IdPhong",
                principalTable: "Phong",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ve_LoaiGhe_IdLoaiGhe",
                table: "Ve");

            migrationBuilder.DropForeignKey(
                name: "FK_Ve_Phong_IdPhong",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_IdLoaiGhe",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "GioChieu",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "IdLoaiGhe",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "NgayChieu",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "QuanHuyen",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "TenGhe",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "TenRap",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "ThanhPho",
                table: "Ve");

            migrationBuilder.RenameColumn(
                name: "IdPhong",
                table: "Ve",
                newName: "IdGhe");

            migrationBuilder.RenameIndex(
                name: "IX_Ve_IdPhong",
                table: "Ve",
                newName: "IX_Ve_IdGhe");

            migrationBuilder.AddColumn<bool>(
                name: "TinhTrang",
                table: "Ve",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CotGhe = table.Column<int>(type: "int", nullable: false),
                    HangGhe = table.Column<int>(type: "int", nullable: false),
                    IdLoaiGhe = table.Column<int>(type: "int", nullable: false),
                    IdPhong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ghe_LoaiGhe_IdLoaiGhe",
                        column: x => x.IdLoaiGhe,
                        principalTable: "LoaiGhe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ghe_Phong_IdPhong",
                        column: x => x.IdPhong,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_IdLoaiGhe",
                table: "Ghe",
                column: "IdLoaiGhe");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_IdPhong",
                table: "Ghe",
                column: "IdPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_Ghe_IdGhe",
                table: "Ve",
                column: "IdGhe",
                principalTable: "Ghe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
