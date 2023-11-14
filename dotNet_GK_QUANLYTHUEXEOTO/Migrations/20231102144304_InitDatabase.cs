using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RentPrice = table.Column<double>(type: "float", nullable: false),
                    CarImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CarTypeId = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "CarImage", "Name", "RentPrice" },
                values: new object[,]
                {
                    { 1, new byte[] {} , "4 chỗ (Mini)", 1000.0 },
                    { 2, new byte[] {}, "4 chỗ (Sedan)", 1200.0 },
                    { 3, new byte[] {}, "4 chỗ (Hatchback)", 1500.0 },
                    { 4, new byte[] {}, "5 chỗ (CUV Gầm cao)", 2000.0 },
                    { 5, new byte[] {}, "7 chỗ (SUV Gầm cao)", 4000.0 },
                    { 6, new byte[] {}, "7 chỗ (MPV Gầm thấp)", 3000.0 },
                    { 7, new byte[] {}, "Bán tải", 500.0 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarTypeId", "Manufacturer", "Model", "Status" },
                values: new object[,]
                {
                    { "75H0123", 3, "KIA", "2023", 0 },
                    { "75H1111", 4, "Mazda", "2023", 0 },
                    { "75H2222", 7, "Huynhdai", "2023", 0 },
                    { "75H6666", 1, "Vinfast", "2023", 0 },
                    { "75H6789", 4, "Tesla", "2023", 0 },
                    { "75H7777", 2, "Tesla", "2023", 0 },
                    { "92H0123", 5, "Audi", "2023", 0 },
                    { "92H1010", 1, "Huynhdai", "2023", 0 },
                    { "92H1111", 5, "Tesla", "2023", 0 },
                    { "92H2222", 6, "Vinfast", "2023", 0 },
                    { "92H6789", 6, "Porsche", "2023", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}
