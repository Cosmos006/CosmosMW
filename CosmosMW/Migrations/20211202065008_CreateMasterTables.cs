using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmosMW.Migrations
{
    public partial class CreateMasterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    AllergyCode = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    AllergyType = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    AllergyName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    ClinicalInformation = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_allergyid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    DiagnosisCode = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    IsDepricated = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_diagnosisid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drug",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    DrugName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    DrugGenericName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    DrugManufacturerName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    DrugForm = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    DrugStrength = table.Column<string>(type: "CHARACTER VARYING", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_drugid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProcedureCode = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    IsDepricated = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_procedureid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergy");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Drug");

            migrationBuilder.DropTable(
                name: "Procedure");
        }
    }
}
