﻿// <auto-generated />
using System;
using Event_Managment_System_Core.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_Managment_System_Core.Migrations
{
    [DbContext(typeof(EventManagemntSystemContext))]
    [Migration("20240426140330_EMS")]
    partial class EMS
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(5422));

                    b.Property<double>("DiscountAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int?>("EventsId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("PromoCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketSerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int?>("Volunteering_WorkshopssId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkshopsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventsId");

                    b.HasIndex("UsersId");

                    b.HasIndex("Volunteering_WorkshopssId");

                    b.HasIndex("WorkshopsId");

                    b.ToTable("Bookings", null, t =>
                        {
                            t.HasCheckConstraint("Ch_Booking_DiscountAmount", "DiscountAmount>=0");

                            t.HasCheckConstraint("Ch_Booking_NetPrice", "NetPrice>=0");

                            t.HasCheckConstraint("Ch_Booking_TaxAmount", "TaxAmount>=0");

                            t.HasCheckConstraint("Ch_Booking_TotalPrice", "TotalPrice>=0");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 4, 26, 17, 3, 30, 547, DateTimeKind.Local).AddTicks(7738));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Carts", null, t =>
                        {
                            t.HasCheckConstraint("CH_Cart_AddingDate", "CreatedDate >= sysdatetime()");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingsId")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventsId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Volunteering_workshopssId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkshopsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingsId");

                    b.HasIndex("CartId");

                    b.HasIndex("EventsId");

                    b.HasIndex("Volunteering_workshopssId");

                    b.HasIndex("WorkshopsId");

                    b.ToTable("CartItems", null, t =>
                        {
                            t.HasCheckConstraint("Ch_note", "len(Note)>=150");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(5m);

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Events", null, t =>
                        {
                            t.HasCheckConstraint("CH_Item__Description", "LEN(Description) >0 ");

                            t.HasCheckConstraint("CH_Item__price", "LEN(Price) >0 ");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 4, 26, 17, 3, 30, 548, DateTimeKind.Local).AddTicks(1963));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("users", null, t =>
                        {
                            t.HasCheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");

                            t.HasCheckConstraint("Ch_User_name", "len(Name)>5");

                            t.HasCheckConstraint("Ch_User_password", "LEN(password) >= 8 AND LEN(password) <= 16");

                            t.HasCheckConstraint("Ch_User_phone", "(len([Phone])=(10) AND ([Phone] like '079%' OR [Phone] like '078%' OR [Phone] like '077%'))");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Volunteering_workshops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Voluntering_workshops", null, t =>
                        {
                            t.HasCheckConstraint("CH_Item__Description", "LEN(Description) >0 ")
                                .HasName("CH_Item__Description1");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(5m);

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Workshops", null, t =>
                        {
                            t.HasCheckConstraint("CH_Item__Description", "LEN(Description) >0 ")
                                .HasName("CH_Item__Description2");

                            t.HasCheckConstraint("CH_Item__price", "LEN(Price) >0 ")
                                .HasName("CH_Item__price1");
                        });
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Booking", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.Event", "Events")
                        .WithMany("Bookings")
                        .HasForeignKey("EventsId");

                    b.HasOne("Event_Managment_System_Core.Models.Entity.User", "Users")
                        .WithMany("Booking")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Volunteering_workshops", "Volunteering_Workshopss")
                        .WithMany("Bookings")
                        .HasForeignKey("Volunteering_WorkshopssId");

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Workshop", "Workshops")
                        .WithMany("Bookings")
                        .HasForeignKey("WorkshopsId");

                    b.Navigation("Events");

                    b.Navigation("Users");

                    b.Navigation("Volunteering_Workshopss");

                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Cart", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.Booking", "Bookings")
                        .WithOne("Carts")
                        .HasForeignKey("Event_Managment_System_Core.Models.Entity.Cart", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_Managment_System_Core.Models.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookings");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.CartItem", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.Booking", "Bookings")
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Event", "Events")
                        .WithMany("CartItems")
                        .HasForeignKey("EventsId");

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Volunteering_workshops", "Volunteering_workshopss")
                        .WithMany("CartItems")
                        .HasForeignKey("Volunteering_workshopssId");

                    b.HasOne("Event_Managment_System_Core.Models.Entity.Workshop", "Workshops")
                        .WithMany("CartItems")
                        .HasForeignKey("WorkshopsId");

                    b.Navigation("Bookings");

                    b.Navigation("Events");

                    b.Navigation("Volunteering_workshopss");

                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Event", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.User", "Users")
                        .WithMany("Events")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Volunteering_workshops", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.User", "Users")
                        .WithMany("Volunteering_workshopss")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Workshop", b =>
                {
                    b.HasOne("Event_Managment_System_Core.Models.Entity.User", "Users")
                        .WithMany("Workshops")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Booking", b =>
                {
                    b.Navigation("Carts")
                        .IsRequired();
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Event", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.User", b =>
                {
                    b.Navigation("Booking");

                    b.Navigation("Events");

                    b.Navigation("Volunteering_workshopss");

                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Volunteering_workshops", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Event_Managment_System_Core.Models.Entity.Workshop", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
