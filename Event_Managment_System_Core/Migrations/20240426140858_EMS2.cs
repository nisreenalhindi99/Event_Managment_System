using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class EMS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_DiscountAmount",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_NetPrice",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_TaxAmount",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(7275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 548, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(3078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Bookings",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Price",
                table: "Bookings",
                sql: "Price>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Tax",
                table: "Bookings",
                sql: "Tax>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_PromoCode",
                table: "Bookings",
                sql: "len(romoCode)<=6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_Price",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_Tax",
                table: "Bookings");

            migrationBuilder.DropCheckConstraint(
                name: "Ch_PromoCode",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 548, DateTimeKind.Local).AddTicks(1963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Bookings",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_DiscountAmount",
                table: "Bookings",
                sql: "DiscountAmount>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_NetPrice",
                table: "Bookings",
                sql: "NetPrice>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_TaxAmount",
                table: "Bookings",
                sql: "TaxAmount>=0");
        }
    }
}
