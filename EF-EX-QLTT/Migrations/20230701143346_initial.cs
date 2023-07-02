using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_EX_QLTT.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    LopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.LopID);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    HocVienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LopID = table.Column<int>(type: "int", nullable: false),
                    NgayDK = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.HocVienID);
                    table.ForeignKey(
                        name: "FK_HocVien_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "LopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopID",
                table: "HocVien",
                column: "LopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "Lop");
        }
    }
}
