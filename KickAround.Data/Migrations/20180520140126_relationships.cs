using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace KickAround.Data.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Matches_MatchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_MatchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Groups_UserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Groups");

            migrationBuilder.CreateTable(
                name: "AttendeeMatch",
                columns: table => new
                {
                    AttendeeId = table.Column<string>(nullable: false),
                    MatchId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeMatch", x => new { x.AttendeeId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_AttendeeMatch_Users_AttendeeId",
                        column: x => x.AttendeeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeMatch_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerGroup",
                columns: table => new
                {
                    PlayerId = table.Column<string>(nullable: false),
                    GroupId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGroup", x => new { x.PlayerId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_PlayerGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGroup_Users_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeMatch_MatchId",
                table: "AttendeeMatch",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGroup_GroupId",
                table: "PlayerGroup",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeMatch");

            migrationBuilder.DropTable(
                name: "PlayerGroup");

            migrationBuilder.AddColumn<string>(
                name: "MatchId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_MatchId",
                table: "Users",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserId",
                table: "Groups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Matches_MatchId",
                table: "Users",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
