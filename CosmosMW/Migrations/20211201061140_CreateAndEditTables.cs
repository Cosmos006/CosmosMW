using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmosMW.Migrations
{
    public partial class CreateAndEditTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UserDetails",
                type: "CHARACTER VARYING",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserDetails",
                type: "CHARACTER VARYING",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Title = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    Contact = table.Column<long>(type: "BIGINT", nullable: false),
                    Specialization = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Email = table.Column<string>(type: "CHARACTER VARYING", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    RoleId = table.Column<Guid>(type: "UUID", nullable: false),
                    UserId = table.Column<Guid>(type: "UUID", nullable: false),
                    IsActive = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employeeid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_RoleMaster_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    SenderId = table.Column<Guid>(type: "UUID", nullable: false),
                    RecieverId = table.Column<Guid>(type: "UUID", nullable: false),
                    SenderMessage = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    ResponseMessage = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    SentDateTime = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    RecievedDateTime = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_notesid", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_RoleId",
                table: "EmployeeDetails",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_UserId",
                table: "EmployeeDetails",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UserDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHARACTER VARYING",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHARACTER VARYING",
                oldNullable: true);
        }
    }
}
