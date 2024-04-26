using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class EMS3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Workshops",
                type: "float",
                nullable: false,
                defaultValue: 5.0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 5m);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Voluntering_workshops",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 99, DateTimeKind.Local).AddTicks(2985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Events",
                type: "float",
                nullable: false,
                defaultValue: 5.0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 5m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 98, DateTimeKind.Local).AddTicks(9263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 98, DateTimeKind.Local).AddTicks(7125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(764));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Workshops",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 5m,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5.0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Voluntering_workshops",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(7275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 99, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 5m,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(3078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 98, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 8, 58, 701, DateTimeKind.Local).AddTicks(764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 12, 27, 98, DateTimeKind.Local).AddTicks(7125));
        }
    }
}
