using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class Event3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_Price",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_PromoCode",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_Tax",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_TotalPrice",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 470, DateTimeKind.Local).AddTicks(9708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 647, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 469, DateTimeKind.Local).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 646, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.AlterColumn<string>(
                name: "PromoCode",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 469, DateTimeKind.Local).AddTicks(6798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 646, DateTimeKind.Local).AddTicks(6752));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 647, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 470, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 646, DateTimeKind.Local).AddTicks(8956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 469, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.AlterColumn<string>(
                name: "PromoCode",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 54, 50, 646, DateTimeKind.Local).AddTicks(6752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 18, 4, 11, 469, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Price",
                table: "Bookings",
                sql: "Price >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_PromoCode",
                table: "Bookings",
                sql: "len(PromoCode) <= 6");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Tax",
                table: "Bookings",
                sql: "Tax >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_TotalPrice",
                table: "Bookings",
                sql: "TotalPrice >= 0");
        }
    }
}
