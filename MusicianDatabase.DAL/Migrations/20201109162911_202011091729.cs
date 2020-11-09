using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicianDatabase.DAL.Migrations
{
    public partial class _202011091729 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigInstrument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instrument = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigInstrument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedById = table.Column<int>(nullable: true),
                    AddedById = table.Column<int>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    LockedById = table.Column<int>(nullable: true),
                    LastEditedById = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musicians_Users_AddedById",
                        column: x => x.AddedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musicians_Users_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Musicians_Users_LastEditedById",
                        column: x => x.LastEditedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Musicians_Users_LockedById",
                        column: x => x.LockedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicianInstruments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicianId = table.Column<int>(nullable: false),
                    ConfigInstrumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianInstruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_ConfigInstrument_ConfigInstrumentId",
                        column: x => x.ConfigInstrumentId,
                        principalTable: "ConfigInstrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstruments_ConfigInstrumentId",
                table: "MusicianInstruments",
                column: "ConfigInstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstruments_MusicianId",
                table: "MusicianInstruments",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_AddedById",
                table: "Musicians",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_DeletedById",
                table: "Musicians",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_LastEditedById",
                table: "Musicians",
                column: "LastEditedById");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_LockedById",
                table: "Musicians",
                column: "LockedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianInstruments");

            migrationBuilder.DropTable(
                name: "ConfigInstrument");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
