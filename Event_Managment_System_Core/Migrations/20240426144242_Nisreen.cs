using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class Nisreen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Events_EventsId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Voluntering_workshops_Volunteering_workshopssId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Workshops_WorkshopsId",
                table: "CartItems");

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
                defaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 754, DateTimeKind.Local).AddTicks(8346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 396, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 753, DateTimeKind.Local).AddTicks(8805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 395, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.AlterColumn<int>(
                name: "WorkshopsId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Volunteering_workshopssId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventsId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 753, DateTimeKind.Local).AddTicks(6615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 395, DateTimeKind.Local).AddTicks(4167));

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Events_EventsId",
                table: "CartItems",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Voluntering_workshops_Volunteering_workshopssId",
                table: "CartItems",
                column: "Volunteering_workshopssId",
                principalTable: "Voluntering_workshops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Workshops_WorkshopsId",
                table: "CartItems",
                column: "WorkshopsId",
                principalTable: "Workshops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Events_EventsId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Voluntering_workshops_Volunteering_workshopssId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Workshops_WorkshopsId",
                table: "CartItems");

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
                defaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 396, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 754, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 395, DateTimeKind.Local).AddTicks(6356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 753, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.AlterColumn<int>(
                name: "WorkshopsId",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Volunteering_workshopssId",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventsId",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 17, 30, 29, 395, DateTimeKind.Local).AddTicks(4167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 17, 42, 42, 753, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Price",
                table: "Bookings",
                sql: "Price>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_PromoCode",
                table: "Bookings",
                sql: "len(romoCode)<=6");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_Tax",
                table: "Bookings",
                sql: "Tax>=0");

            migrationBuilder.AddCheckConstraint(
                name: "Ch_Booking_TotalPrice",
                table: "Bookings",
                sql: "TotalPrice>=0");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Events_EventsId",
                table: "CartItems",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Voluntering_workshops_Volunteering_workshopssId",
                table: "CartItems",
                column: "Volunteering_workshopssId",
                principalTable: "Voluntering_workshops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Workshops_WorkshopsId",
                table: "CartItems",
                column: "WorkshopsId",
                principalTable: "Workshops",
                principalColumn: "Id");
        }
    }
}
