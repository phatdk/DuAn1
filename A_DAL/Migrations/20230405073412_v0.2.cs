using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KMHD",
                table: "hoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_NVHD",
                table: "hoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_SPLoai",
                table: "sanPhams");

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "sanPhams",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdLoai",
                table: "sanPhams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "sanPhams",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "nhanViens",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Sdt",
                table: "nhanViens",
                type: "varchar(13)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(13)");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "nhanViens",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "DkGiam",
                table: "khuyenMais",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "TongTien",
                table: "hoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "hoaDons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNv",
                table: "hoaDons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdKm",
                table: "hoaDons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "ban_HDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_KMHD",
                table: "hoaDons",
                column: "IdKm",
                principalTable: "khuyenMais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NVHD",
                table: "hoaDons",
                column: "IdNv",
                principalTable: "nhanViens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SPLoai",
                table: "sanPhams",
                column: "IdLoai",
                principalTable: "loaiSps",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KMHD",
                table: "hoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_NVHD",
                table: "hoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_SPLoai",
                table: "sanPhams");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ban_HDs");

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "sanPhams",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdLoai",
                table: "sanPhams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "sanPhams",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "nhanViens",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sdt",
                table: "nhanViens",
                type: "varchar(13)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "nhanViens",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DkGiam",
                table: "khuyenMais",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TongTien",
                table: "hoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "hoaDons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNv",
                table: "hoaDons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdKm",
                table: "hoaDons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KMHD",
                table: "hoaDons",
                column: "IdKm",
                principalTable: "khuyenMais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NVHD",
                table: "hoaDons",
                column: "IdNv",
                principalTable: "nhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SPLoai",
                table: "sanPhams",
                column: "IdLoai",
                principalTable: "loaiSps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
