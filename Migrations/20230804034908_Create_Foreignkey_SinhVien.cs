using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenDuongHung_01.Migrations
{
    /// <inheritdoc />
    public partial class Create_Foreignkey_SinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_Malop",
                table: "SinhVien",
                column: "Malop");

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVien_LopHoc_Malop",
                table: "SinhVien",
                column: "Malop",
                principalTable: "LopHoc",
                principalColumn: "Malop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhVien_LopHoc_Malop",
                table: "SinhVien");

            migrationBuilder.DropIndex(
                name: "IX_SinhVien_Malop",
                table: "SinhVien");
        }
    }
}
