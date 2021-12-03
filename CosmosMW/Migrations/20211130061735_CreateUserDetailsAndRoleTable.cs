using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmosMW.Migrations
{
    public partial class CreateUserDetailsAndRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Role = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    RoleMasterRoleId = table.Column<Guid>(type: "UUID", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roleid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMaster_RoleMaster_RoleMasterRoleId",
                        column: x => x.RoleMasterRoleId,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    IsFirstLogIn = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    NoOfAttempts = table.Column<int>(type: "INT", nullable: false),
                    RoleId = table.Column<Guid>(type: "UUID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_userid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_RoleMaster_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleMaster_RoleMasterRoleId",
                table: "RoleMaster",
                column: "RoleMasterRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_RoleId",
                table: "UserDetails",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "RoleMaster");
        }
    }
}
