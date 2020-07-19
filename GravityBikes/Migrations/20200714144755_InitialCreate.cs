using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GravityBikes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeParks",
                columns: table => new
                {
                    BikeParkID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BikesCount = table.Column<int>(nullable: false),
                    ParkTicketLimit = table.Column<int>(nullable: false),
                    LiftTicketLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeParks", x => x.BikeParkID);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BikePrice = table.Column<int>(nullable: false),
                    BikeIsAvaible = table.Column<bool>(nullable: false),
                    BikeModel = table.Column<string>(nullable: true),
                    BikeSize = table.Column<byte>(nullable: false),
                    BikeGender = table.Column<byte>(nullable: false),
                    BikeType = table.Column<byte>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeId);
                });

            migrationBuilder.CreateTable(
                name: "DaysLimits",
                columns: table => new
                {
                    DaysLimitID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParkTicketLimit = table.Column<int>(nullable: false),
                    LiftTicketLimit = table.Column<int>(nullable: false),
                    ParkTicketActuallyCount = table.Column<int>(nullable: false),
                    LiftTicketActuallyCount = table.Column<int>(nullable: false),
                    LimitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysLimits", x => x.DaysLimitID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    IsUserActive = table.Column<bool>(nullable: false),
                    IsUserVerifed = table.Column<bool>(nullable: false),
                    AllowUserMarketing = table.Column<bool>(nullable: false),
                    UserCreatioDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "BikeReservations",
                columns: table => new
                {
                    BikeReservationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BikeReservationDateOfPayment = table.Column<DateTime>(nullable: false),
                    BikeReservationIsPaid = table.Column<bool>(nullable: false),
                    DateOfReservation = table.Column<DateTime>(nullable: false),
                    ReservedBikeBikeId = table.Column<int>(nullable: true),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeReservations", x => x.BikeReservationID);
                    table.ForeignKey(
                        name: "FK_BikeReservations_Bikes_ReservedBikeBikeId",
                        column: x => x.ReservedBikeBikeId,
                        principalTable: "Bikes",
                        principalColumn: "BikeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BikeReservations_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiftTicketReservations",
                columns: table => new
                {
                    LiftTicketReservationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LiftTicketReservationDateOfOrder = table.Column<DateTime>(nullable: false),
                    LiftTicketReservationDateOfPayment = table.Column<DateTime>(nullable: false),
                    LiftTicketReservationIsPaid = table.Column<bool>(nullable: false),
                    LiftTicketReservationOwnerId = table.Column<int>(nullable: false),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftTicketReservations", x => x.LiftTicketReservationID);
                    table.ForeignKey(
                        name: "FK_LiftTicketReservations_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkTicketReservations",
                columns: table => new
                {
                    ParkTicketReservationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParkTicketReservationDateOfOrder = table.Column<DateTime>(nullable: false),
                    ParkTicketReservationDateOfPayment = table.Column<DateTime>(nullable: false),
                    ParkTicketReservationIsPaid = table.Column<bool>(nullable: false),
                    ParkTicketReservationOwnerId = table.Column<int>(nullable: false),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkTicketReservations", x => x.ParkTicketReservationID);
                    table.ForeignKey(
                        name: "FK_ParkTicketReservations_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiftTickets",
                columns: table => new
                {
                    LiftTicketID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LiftTicketUseCount = table.Column<int>(nullable: false),
                    LiftTicketDaysCount = table.Column<int>(nullable: false),
                    LiftTicketDiscountType = table.Column<string>(nullable: true),
                    LiftTicketPrice = table.Column<int>(nullable: false),
                    LiftTicketType = table.Column<string>(nullable: true),
                    LiftTicketDateOfStart = table.Column<DateTime>(nullable: false),
                    LiftTicketDateOfStop = table.Column<DateTime>(nullable: false),
                    BikeDateOfHireStop = table.Column<DateTime>(nullable: false),
                    LiftTicketReservationID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftTickets", x => x.LiftTicketID);
                    table.ForeignKey(
                        name: "FK_LiftTickets_LiftTicketReservations_LiftTicketReservationID1",
                        column: x => x.LiftTicketReservationID1,
                        principalTable: "LiftTicketReservations",
                        principalColumn: "LiftTicketReservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkTickets",
                columns: table => new
                {
                    ParkTicketID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParkTicketDaysCount = table.Column<int>(nullable: false),
                    ParkTicketDiscountType = table.Column<string>(nullable: true),
                    ParkTicketPrice = table.Column<int>(nullable: false),
                    ParkTicketDateOfStart = table.Column<DateTime>(nullable: false),
                    ParkTicketDateOfStop = table.Column<DateTime>(nullable: false),
                    ParkTicketReservationID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkTickets", x => x.ParkTicketID);
                    table.ForeignKey(
                        name: "FK_ParkTickets_ParkTicketReservations_ParkTicketReservationID1",
                        column: x => x.ParkTicketReservationID1,
                        principalTable: "ParkTicketReservations",
                        principalColumn: "ParkTicketReservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeReservations_ReservedBikeBikeId",
                table: "BikeReservations",
                column: "ReservedBikeBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeReservations_userID",
                table: "BikeReservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_LiftTicketReservations_userID",
                table: "LiftTicketReservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_LiftTickets_LiftTicketReservationID1",
                table: "LiftTickets",
                column: "LiftTicketReservationID1");

            migrationBuilder.CreateIndex(
                name: "IX_ParkTicketReservations_userID",
                table: "ParkTicketReservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkTickets_ParkTicketReservationID1",
                table: "ParkTickets",
                column: "ParkTicketReservationID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeParks");

            migrationBuilder.DropTable(
                name: "BikeReservations");

            migrationBuilder.DropTable(
                name: "DaysLimits");

            migrationBuilder.DropTable(
                name: "LiftTickets");

            migrationBuilder.DropTable(
                name: "ParkTickets");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "LiftTicketReservations");

            migrationBuilder.DropTable(
                name: "ParkTicketReservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
