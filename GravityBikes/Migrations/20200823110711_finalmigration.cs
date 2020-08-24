using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GravityBikes.Migrations
{
    public partial class finalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    BikeModel = table.Column<string>(nullable: true),
                    BikeSize = table.Column<byte>(nullable: false),
                    BikeGender = table.Column<byte>(nullable: false),
                    BikeDescription = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    PublicId = table.Column<string>(nullable: true)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    LiftTicketDateOfStart = table.Column<DateTime>(nullable: false),
                    LiftTicketDateOfStop = table.Column<DateTime>(nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftTicketReservations", x => x.LiftTicketReservationID);
                    table.ForeignKey(
                        name: "FK_LiftTicketReservations_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_ParkTicketReservations_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_BikeReservations_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    LiftTicketPriceReduced = table.Column<int>(nullable: false),
                    IsDayLimitedTicket = table.Column<bool>(nullable: false),
                    LiftTicketPrice = table.Column<int>(nullable: false),
                    LiftTicketType = table.Column<string>(nullable: true),
                    LimitStart = table.Column<DateTime>(nullable: false),
                    LimitStop = table.Column<DateTime>(nullable: false),
                    LiftTicketReservationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftTickets", x => x.LiftTicketID);
                    table.ForeignKey(
                        name: "FK_LiftTickets_LiftTicketReservations_LiftTicketReservationID",
                        column: x => x.LiftTicketReservationID,
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BikeReservations_ReservedBikeBikeId",
                table: "BikeReservations",
                column: "ReservedBikeBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeReservations_userID",
                table: "BikeReservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_LiftTicketReservations_userId",
                table: "LiftTicketReservations",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_LiftTickets_LiftTicketReservationID",
                table: "LiftTickets",
                column: "LiftTicketReservationID");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "LiftTicketReservations");

            migrationBuilder.DropTable(
                name: "ParkTicketReservations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
