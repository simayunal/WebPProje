using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje1.Migrations
{
    /// <inheritdoc />
    public partial class simayy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Itinerarys",
                table: "Itinerarys");

            migrationBuilder.RenameTable(
                name: "Itinerarys",
                newName: "Itineraries");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalAirport",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureCity",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureDate",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureTime",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Itineraries",
                table: "Itineraries",
                column: "ItineraryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Itineraries",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "ArrivalAirport",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Itineraries");

            migrationBuilder.RenameTable(
                name: "Itineraries",
                newName: "Itinerarys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Itinerarys",
                table: "Itinerarys",
                column: "ItineraryID");
        }
    }
}
