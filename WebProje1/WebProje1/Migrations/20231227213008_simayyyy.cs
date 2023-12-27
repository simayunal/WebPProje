using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje1.Migrations
{
    /// <inheritdoc />
    public partial class simayyyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArrivalAirport",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureAirport",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureDate",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureTime",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AircraftID",
                table: "Flights",
                column: "AircraftID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ItineraryID",
                table: "Flights",
                column: "ItineraryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Aircrafts_AircraftID",
                table: "Flights",
                column: "AircraftID",
                principalTable: "Aircrafts",
                principalColumn: "AircraftID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Itineraries_ItineraryID",
                table: "Flights",
                column: "ItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Aircrafts_AircraftID",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Itineraries_ItineraryID",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_AircraftID",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ItineraryID",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ArrivalAirport",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DepartureAirport",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Reservations");
        }
    }
}
