using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e0336913-4f8e-4c6f-9320-2672607ea868", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELwplSbKsFdmz4EXDbLd0HtPoZJLwYo5W5nauw4t1P7mE+dOCjGzvlEE1fLFsRRC/A==", null, false, "2e1c7711-fdb6-4a46-a894-76ccee440eb4", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8160), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8164), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8164), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8514), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8516), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8710), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8712), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8713), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 11, 25, 19, 8, 29, 897, DateTimeKind.Local).AddTicks(8715), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
