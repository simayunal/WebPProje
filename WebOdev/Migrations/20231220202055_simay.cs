using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOdev.Migrations
{
    /// <inheritdoc />
    public partial class simay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "patientID",
                table: "Appointments",
                newName: "PatientID");

            migrationBuilder.AlterColumn<string>(
                name: "ProfessionName",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "Policlinics",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoctorName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Policlinics_AppointmentID",
                table: "Policlinics",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Policlinics_Appointments_AppointmentID",
                table: "Policlinics",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "AppointmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policlinics_Appointments_AppointmentID",
                table: "Policlinics");

            migrationBuilder.DropIndex(
                name: "IX_Policlinics_AppointmentID",
                table: "Policlinics");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "Policlinics");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Appointments",
                newName: "patientID");

            migrationBuilder.AlterColumn<string>(
                name: "ProfessionName",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoctorName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
