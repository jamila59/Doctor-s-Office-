using Microsoft.EntityFrameworkCore.Migrations;

namespace Physician.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patients",
                newName: "PatientName");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Doctors",
                newName: "DoctorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatientName",
                table: "Patients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "Doctors",
                newName: "Specialty");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Doctors",
                nullable: true);
        }
    }
}
