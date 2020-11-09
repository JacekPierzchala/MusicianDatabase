using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicianDatabase.DAL.Migrations
{
    public partial class _202011091712 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigEntitlements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entitlement = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigEntitlements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleEntitlements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigRoleId = table.Column<int>(nullable: false),
                    ConfigEntitlementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEntitlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleEntitlements_ConfigEntitlements_ConfigEntitlementId",
                        column: x => x.ConfigEntitlementId,
                        principalTable: "ConfigEntitlements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleEntitlements_ConfigRoles_ConfigRoleId",
                        column: x => x.ConfigRoleId,
                        principalTable: "ConfigRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ConfigRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_ConfigRoles_ConfigRoleId",
                        column: x => x.ConfigRoleId,
                        principalTable: "ConfigRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleEntitlements_ConfigEntitlementId",
                table: "RoleEntitlements",
                column: "ConfigEntitlementId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleEntitlements_ConfigRoleId",
                table: "RoleEntitlements",
                column: "ConfigRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ConfigRoleId",
                table: "UserRoles",
                column: "ConfigRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleEntitlements");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "ConfigEntitlements");

            migrationBuilder.DropTable(
                name: "ConfigRoles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
