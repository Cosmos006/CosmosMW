using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmosMW.Migrations
{
    public partial class CreateAppointmentsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    AppointmentType = table.Column<string>(type: "CHAR(1)", nullable: false),
                    PatientId = table.Column<Guid>(type: "UUID", nullable: false),
                    PhysicianId = table.Column<Guid>(type: "UUID", nullable: false),
                    NurseId = table.Column<Guid>(type: "UUID", nullable: false),
                    Diagnosis = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Status = table.Column<string>(type: "CHAR(1)", nullable: false),
                    AppointmentDateTime = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    ModifiedReason = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "UUID", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DeletedReason = table.Column<string>(type: "CHARACTER VARYING", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointmentid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
