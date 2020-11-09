using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicianDatabase.DAL.Migrations
{
    public partial class _202011091803 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Musicians",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Musicians",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDate",
                table: "Musicians",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedById = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    AddedById = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    LockedById = table.Column<int>(nullable: true),
                    LastEditedById = table.Column<int>(nullable: true),
                    LastEditedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DissolvedDate = table.Column<DateTime>(nullable: false),
                    CurrentSeq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bands_Users_AddedById",
                        column: x => x.AddedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bands_Users_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bands_Users_LastEditedById",
                        column: x => x.LastEditedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bands_Users_LockedById",
                        column: x => x.LockedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfigStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicianInstrumentBands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandId = table.Column<int>(nullable: false),
                    MusicianInstrumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianInstrumentBands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicianInstrumentBands_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianInstrumentBands_MusicianInstruments_MusicianInstrumentId",
                        column: x => x.MusicianInstrumentId,
                        principalTable: "MusicianInstruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StatusChangeBand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandId = table.Column<int>(nullable: false),
                    ConfigStatusId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Seq = table.Column<int>(nullable: false),
                    ActionLog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusChangeBand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusChangeBand_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatusChangeBand_ConfigStatus_ConfigStatusId",
                        column: x => x.ConfigStatusId,
                        principalTable: "ConfigStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatusChangeBand_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bands_AddedById",
                table: "Bands",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bands_DeletedById",
                table: "Bands",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bands_LastEditedById",
                table: "Bands",
                column: "LastEditedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bands_LockedById",
                table: "Bands",
                column: "LockedById");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstrumentBands_BandId",
                table: "MusicianInstrumentBands",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstrumentBands_MusicianInstrumentId",
                table: "MusicianInstrumentBands",
                column: "MusicianInstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusChangeBand_BandId",
                table: "StatusChangeBand",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusChangeBand_ConfigStatusId",
                table: "StatusChangeBand",
                column: "ConfigStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusChangeBand_UserId",
                table: "StatusChangeBand",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianInstrumentBands");

            migrationBuilder.DropTable(
                name: "StatusChangeBand");

            migrationBuilder.DropTable(
                name: "Bands");

            migrationBuilder.DropTable(
                name: "ConfigStatus");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "LastEditedDate",
                table: "Musicians");
        }
    }
}
