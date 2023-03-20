using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenBan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayBd = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKt = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    PhamTramGiam = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    SoTienGiam = table.Column<int>(type: "int", nullable: false),
                    DkGiam = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loaiSps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiSps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Sdt = table.Column<string>(type: "varchar(13)", nullable: false),
                    ChucVu = table.Column<int>(type: "int", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSp = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    HinhAnh = table.Column<string>(type: "varchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPKM",
                        column: x => x.IdKm,
                        principalTable: "khuyenMais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPLoai",
                        column: x => x.IdLoai,
                        principalTable: "loaiSps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNv = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: false),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NVHD",
                        column: x => x.IdNv,
                        principalTable: "nhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ban_HDs",
                columns: table => new
                {
                    IdBan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHd = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ban_HDs", x => new { x.IdBan, x.IdHd });
                    table.ForeignKey(
                        name: "FK_Ban",
                        column: x => x.IdBan,
                        principalTable: "bans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ban_HDs_hoaDons_IdHd",
                        column: x => x.IdHd,
                        principalTable: "hoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sP_HDs",
                columns: table => new
                {
                    IdHd = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sP_HDs", x => new { x.IdHd, x.IdSp });
                    table.ForeignKey(
                        name: "FK_sP_HDs_hoaDons_IdHd",
                        column: x => x.IdHd,
                        principalTable: "hoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPHD",
                        column: x => x.IdSp,
                        principalTable: "sanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ban_HDs_IdHd",
                table: "ban_HDs",
                column: "IdHd");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IdNv",
                table: "hoaDons",
                column: "IdNv");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdKm",
                table: "sanPhams",
                column: "IdKm");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdLoai",
                table: "sanPhams",
                column: "IdLoai");

            migrationBuilder.CreateIndex(
                name: "IX_sP_HDs_IdSp",
                table: "sP_HDs",
                column: "IdSp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ban_HDs");

            migrationBuilder.DropTable(
                name: "sP_HDs");

            migrationBuilder.DropTable(
                name: "bans");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "loaiSps");
        }
    }
}
