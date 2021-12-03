using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmosMW.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientRelativeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Title = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Address = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    Relation = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Email = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    Contact = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRelativeDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDemographicDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    FirstName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Age = table.Column<int>(type: "INT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    Contact = table.Column<long>(type: "BIGINT", nullable: false),
                    Email = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    Gender = table.Column<string>(type: "CHAR(1)", nullable: false),
                    Race = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Ethinicity = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Address = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    PreviousAllergies = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    IsFatal = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    PatientRelativeId = table.Column<Guid>(type: "UUID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patientdemographicid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDemographicDetails_PatientRelativeDetails_PatientRel~",
                        column: x => x.PatientRelativeId,
                        principalTable: "PatientRelativeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Title = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    FirstName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Contact = table.Column<long>(type: "BIGINT", nullable: false),
                    PatientDemographicId = table.Column<Guid>(type: "UUID", nullable: false),
                    UserId = table.Column<Guid>(type: "UUID", nullable: false),
                    IsActive = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patientdetailsid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDetails_PatientDemographicDetails_PatientDemographic~",
                        column: x => x.PatientDemographicId,
                        principalTable: "PatientDemographicDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDetails_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientDemographicDetails_PatientRelativeId",
                table: "PatientDemographicDetails",
                column: "PatientRelativeId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDetails_PatientDemographicId",
                table: "PatientDetails",
                column: "PatientDemographicId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDetails_UserId",
                table: "PatientDetails",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientDetails");

            migrationBuilder.DropTable(
                name: "PatientDemographicDetails");

            migrationBuilder.DropTable(
                name: "PatientRelativeDetails");
        }
    }
}
