using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    /// <inheritdoc />
    public partial class updateCarTypeModelV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "CarImage",
               table: "CarTypes",
               type: "nvarchar(max)",
               nullable: false,
               oldClrType: typeof(byte[]),
               oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "CarImage", "Name", "RentPrice" },
                values: new object[,]
                {
                    { 1, "../../../Resources/Images/CarTypes/MINI.png", "4 chỗ (Mini)", 1000.0 },
                    { 2, "../../../Resources/Images/CarTypes/SEDAN.png", "4 chỗ (Sedan)", 1200.0 },
                    { 3, "../../../Resources/Images/CarTypes/HATCHBACK.png", "4 chỗ (Hatchback)", 1500.0 },
                    { 4, "../../../Resources/Images/CarTypes/CUV.png", "5 chỗ (CUV Gầm cao)", 2000.0 },
                    { 5, "../../../Resources/Images/CarTypes/SUV.png", "7 chỗ (SUV Gầm cao)", 4000.0 },
                    { 6, "../../../Resources/Images/CarTypes/MPV.png", "7 chỗ (MPV Gầm thấp)", 3000.0 },
                    { 7, "../../../Resources/Images/CarTypes/PICKUP.png", "Bán tải", 500.0 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
