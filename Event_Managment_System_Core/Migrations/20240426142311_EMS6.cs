using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class EMS6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Workshops",
                type: "real",
                nullable: false,
                defaultValue: 5f,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5.0);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Voluntering_workshops",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 322, DateTimeKind.Local).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 569, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Events",
                type: "real",
                nullable: false,
                defaultValue: 5f,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 321, DateTimeKind.Local).AddTicks(588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.AlterColumn<float>(
                name: "TotalPrice",
                table: "Bookings",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Tax",
                table: "Bookings",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Bookings",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "DiscountAmount",
                table: "Bookings",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 320, DateTimeKind.Local).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(1588));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Workshops",
                type: "float",
                nullable: false,
                defaultValue: 5.0,
                oldClrType: typeof(float),
                oldType: "real",
                oldDefaultValue: 5f);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Voluntering_workshops",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 569, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 322, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Events",
                type: "float",
                nullable: false,
                defaultValue: 5.0,
                oldClrType: typeof(float),
                oldType: "real",
                oldDefaultValue: 5f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(3909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 321, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Bookings",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Tax",
                table: "Bookings",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Bookings",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "DiscountAmount",
                table: "Bookings",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "real",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 19, 22, 568, DateTimeKind.Local).AddTicks(1588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 23, 11, 320, DateTimeKind.Local).AddTicks(7964));
        }
    }
}
