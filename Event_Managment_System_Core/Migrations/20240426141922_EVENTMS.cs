using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class EVENTMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Ch_PromoCode",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 569, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 299, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(3909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 298, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(1588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 298, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "Bookings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "Bookings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_PromoCode",
                table: "Bookings",
                sql: "len(romoCode)<=6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Ch_Booking_PromoCode",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 299, DateTimeKind.Local).AddTicks(9026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 569, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 298, DateTimeKind.Local).AddTicks(8723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 13, 40, 298, DateTimeKind.Local).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.AddCheckConstraint(
                name: "Ch_PromoCode",
                table: "Bookings",
                sql: "len(romoCode)<=6");
        }
    }
}
