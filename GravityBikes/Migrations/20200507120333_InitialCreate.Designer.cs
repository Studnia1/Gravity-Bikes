﻿// <auto-generated />
using System;
using GravityBikes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GravityBikes.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200507120333_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("GravityBikes.Data.Models.Bike", b =>
                {
                    b.Property<int>("BikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BikeDateOfHireStart")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BikeDateOfHireStop")
                        .HasColumnType("TEXT");

                    b.Property<int>("BikeGender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikeHireDaysCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BikeIsAvaible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BikeModel")
                        .HasColumnType("TEXT");

                    b.Property<int>("BikePrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BikeReservationID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikeSize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikeType")
                        .HasColumnType("INTEGER");

                    b.HasKey("BikeId");

                    b.HasIndex("BikeReservationID");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.BikePark", b =>
                {
                    b.Property<int>("BikeParkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikesCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LiftTicketLimit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParkTicketLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("BikeParkID");

                    b.ToTable("BikeParks");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.BikeReservation", b =>
                {
                    b.Property<int>("BikeReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BikeReservationDateOfOrder")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BikeReservationDateOfPayment")
                        .HasColumnType("TEXT");

                    b.Property<bool>("BikeReservationIsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikeReservationOwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BikeReservationID");

                    b.ToTable("BikeReservations");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.DaysLimit", b =>
                {
                    b.Property<int>("DaysLimitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LiftTicketActuallyCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LiftTicketLimit")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LimitDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParkTicketActuallyCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParkTicketLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("DaysLimitID");

                    b.ToTable("DaysLimits");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.LiftTicket", b =>
                {
                    b.Property<int>("LiftTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BikeDateOfHireStop")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LiftTicketDateOfStart")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LiftTicketDateOfStop")
                        .HasColumnType("TEXT");

                    b.Property<int>("LiftTicketDaysCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LiftTicketDiscountType")
                        .HasColumnType("TEXT");

                    b.Property<int>("LiftTicketPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LiftTicketReservationID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LiftTicketType")
                        .HasColumnType("TEXT");

                    b.Property<int>("LiftTicketUseCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("LiftTicketID");

                    b.HasIndex("LiftTicketReservationID");

                    b.ToTable("LiftTickets");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.LiftTicketReservation", b =>
                {
                    b.Property<int>("LiftTicketReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LiftTicketReservationDateOfOrder")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LiftTicketReservationDateOfPayment")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LiftTicketReservationIsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LiftTicketReservationOwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LiftTicketReservationID");

                    b.ToTable("LiftTicketReservations");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.ParkTicket", b =>
                {
                    b.Property<int>("ParkTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ParkTicketDateOfStart")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ParkTicketDateOfStop")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParkTicketDaysCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParkTicketDiscountType")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParkTicketPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParkTicketReservationID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParkTicketID");

                    b.HasIndex("ParkTicketReservationID");

                    b.ToTable("ParkTickets");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.ParkTicketReservation", b =>
                {
                    b.Property<int>("ParkTicketReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ParkTicketReservationDateOfOrder")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ParkTicketReservationDateOfPayment")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ParkTicketReservationIsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParkTicketReservationOwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParkTicketReservationID");

                    b.ToTable("ParkTicketReservations");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowUserMarketing")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUserActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUserVerifed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UserCreatioDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPassword")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.Bike", b =>
                {
                    b.HasOne("GravityBikes.Data.Models.BikeReservation", null)
                        .WithMany("ReservedBikes")
                        .HasForeignKey("BikeReservationID");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.LiftTicket", b =>
                {
                    b.HasOne("GravityBikes.Data.Models.LiftTicketReservation", null)
                        .WithMany("ReservedLiftTickets")
                        .HasForeignKey("LiftTicketReservationID");
                });

            modelBuilder.Entity("GravityBikes.Data.Models.ParkTicket", b =>
                {
                    b.HasOne("GravityBikes.Data.Models.ParkTicketReservation", null)
                        .WithMany("ReservedParkTicket")
                        .HasForeignKey("ParkTicketReservationID");
                });
#pragma warning restore 612, 618
        }
    }
}
