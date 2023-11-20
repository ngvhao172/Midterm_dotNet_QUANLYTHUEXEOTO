using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    /// <inheritdoc />
    public partial class addUserSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Dob", "EmployeeEmail", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Hue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", "0123456789" },
                    { 2, "Quang Nam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", "User", "0987654321" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EmployeeEmail", "EmployeeId", "Password" },
                values: new object[,]
                {
                    { "admin@gmail.com", 1, "admin" },
                    { "user@gmail.com", 2, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeEmail",
                keyValue: "admin@gmail.com");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeEmail",
                keyValue: "user@gmail.com");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
