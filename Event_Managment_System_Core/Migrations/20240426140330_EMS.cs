using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    /// <inheritdoc />
    public partial class EMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 548, DateTimeKind.Local).AddTicks(1963))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.CheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");
                    table.CheckConstraint("Ch_User_name", "len(Name)>5");
                    table.CheckConstraint("Ch_User_password", "LEN(password) >= 8 AND LEN(password) <= 16");
                    table.CheckConstraint("Ch_User_phone", "(len([Phone])=(10) AND ([Phone] like '079%' OR [Phone] like '078%' OR [Phone] like '077%'))");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 5m),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.CheckConstraint("CH_Item__Description", "LEN(Description) >0 ");
                    table.CheckConstraint("CH_Item__price", "LEN(Price) >0 ");
                    table.ForeignKey(
                        name: "FK_Events_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voluntering_workshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluntering_workshops", x => x.Id);
                    table.CheckConstraint("CH_Item__Description1", "LEN(Description) >0 ");
                    table.ForeignKey(
                        name: "FK_Voluntering_workshops_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 5m),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.Id);
                    table.CheckConstraint("CH_Item__Description2", "LEN(Description) >0 ");
                    table.CheckConstraint("CH_Item__price1", "LEN(Price) >0 ");
                    table.ForeignKey(
                        name: "FK_Workshops_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: true),
                    WorkshopsId = table.Column<int>(type: "int", nullable: true),
                    Volunteering_WorkshopssId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(5422))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.CheckConstraint("Ch_Booking_DiscountAmount", "DiscountAmount>=0");
                    table.CheckConstraint("Ch_Booking_NetPrice", "NetPrice>=0");
                    table.CheckConstraint("Ch_Booking_TaxAmount", "TaxAmount>=0");
                    table.CheckConstraint("Ch_Booking_TotalPrice", "TotalPrice>=0");
                    table.ForeignKey(
                        name: "FK_Bookings_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Voluntering_workshops_Volunteering_WorkshopssId",
                        column: x => x.Volunteering_WorkshopssId,
                        principalTable: "Voluntering_workshops",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Workshops_WorkshopsId",
                        column: x => x.WorkshopsId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(7738))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.CheckConstraint("CH_Cart_AddingDate", "CreatedDate >= sysdatetime()");
                    table.ForeignKey(
                        name: "FK_Carts_Bookings_Id",
                        column: x => x.Id,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingsId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: true),
                    WorkshopsId = table.Column<int>(type: "int", nullable: true),
                    Volunteering_workshopssId = table.Column<int>(type: "int", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.CheckConstraint("Ch_note", "len(Note)>=150");
                    table.ForeignKey(
                        name: "FK_CartItems_Bookings_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_Voluntering_workshops_Volunteering_workshopssId",
                        column: x => x.Volunteering_workshopssId,
                        principalTable: "Voluntering_workshops",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_Workshops_WorkshopsId",
                        column: x => x.WorkshopsId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_EventsId",
                table: "Bookings",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UsersId",
                table: "Bookings",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Volunteering_WorkshopssId",
                table: "Bookings",
                column: "Volunteering_WorkshopssId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_WorkshopsId",
                table: "Bookings",
                column: "WorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookingsId",
                table: "CartItems",
                column: "BookingsId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_EventsId",
                table: "CartItems",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_Volunteering_workshopssId",
                table: "CartItems",
                column: "Volunteering_workshopssId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_WorkshopsId",
                table: "CartItems",
                column: "WorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UsersId",
                table: "Carts",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UsersId",
                table: "Events",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Phone",
                table: "users",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voluntering_workshops_UsersId",
                table: "Voluntering_workshops",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshops_UsersId",
                table: "Workshops",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Voluntering_workshops");

            migrationBuilder.DropTable(
                name: "Workshops");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
