using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    /// <inheritdoc />
    public partial class updateSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Bản đồ", 1000.0 },
                    { 2, "Camera cập lề", 1000.0 },
                    { 3, "Cảm biến lốp", 1000.0 },
                    { 4, "Cửa số trời", 1000.0 },
                    { 5, "Khe cắm USB", 1000.0 },
                    { 6, "Nắp thùng xe bán tải", 1000.0 },
                    { 7, "Bluetooth", 1000.0 },
                    { 8, "Camera hành trình", 1000.0 },
                    { 9, "Cảm biến va chạm", 1000.0 },
                    { 10, "Định vị GPS", 1000.0 },
                    { 11, "Lốp dự phòng", 1000.0 },
                    { 12, "Camera 360", 1000.0 },
                    { 13, "Camera lùi", 1000.0 },
                    { 14, "Cảnh báo tốc độ", 1000.0 }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Xăng", 1000.0 },
                    { 2, "Dầu Diesel", 1500.0 },
                    { 3, "Điện", 2000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
