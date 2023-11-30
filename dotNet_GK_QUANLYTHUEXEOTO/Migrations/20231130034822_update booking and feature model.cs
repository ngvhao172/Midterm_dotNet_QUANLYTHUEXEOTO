using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    /// <inheritdoc />
    public partial class updatebookingandfeaturemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Bookings_BookingId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_BookingId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Features");

            migrationBuilder.CreateTable(
                name: "BookingFeature",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    bookingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingFeature", x => new { x.FeaturesId, x.bookingsId });
                    table.ForeignKey(
                        name: "FK_BookingFeature_Bookings_bookingsId",
                        column: x => x.bookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingFeature_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingFeature_bookingsId",
                table: "BookingFeature",
                column: "bookingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingFeature");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 11,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 12,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 13,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 14,
                column: "BookingId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Features_BookingId",
                table: "Features",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Bookings_BookingId",
                table: "Features",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }
    }
}
