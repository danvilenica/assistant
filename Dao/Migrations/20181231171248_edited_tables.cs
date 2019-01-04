using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dao.Migrations
{
    public partial class edited_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CleanSheets",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Goals",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PenaltiesScored",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PenaltiesWon",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedCards",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YellowCards",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "PlayersMatchStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayersMatchStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonTeamId",
                table: "PlayersMatchStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TeamPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayersMatchStats_MatchId",
                table: "PlayersMatchStats",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersMatchStats_PlayerId",
                table: "PlayersMatchStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersMatchStats_SeasonTeamId",
                table: "PlayersMatchStats",
                column: "SeasonTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_PlayerId",
                table: "TeamPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_SeasonId",
                table: "TeamPlayers",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_TeamId",
                table: "TeamPlayers",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersMatchStats_Matches_MatchId",
                table: "PlayersMatchStats",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersMatchStats_Players_PlayerId",
                table: "PlayersMatchStats",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersMatchStats_SeasonTeams_SeasonTeamId",
                table: "PlayersMatchStats",
                column: "SeasonTeamId",
                principalTable: "SeasonTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersMatchStats_Matches_MatchId",
                table: "PlayersMatchStats");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersMatchStats_Players_PlayerId",
                table: "PlayersMatchStats");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersMatchStats_SeasonTeams_SeasonTeamId",
                table: "PlayersMatchStats");

            migrationBuilder.DropTable(
                name: "TeamPlayers");

            migrationBuilder.DropIndex(
                name: "IX_PlayersMatchStats_MatchId",
                table: "PlayersMatchStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayersMatchStats_PlayerId",
                table: "PlayersMatchStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayersMatchStats_SeasonTeamId",
                table: "PlayersMatchStats");

            migrationBuilder.DropColumn(
                name: "CleanSheets",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "PenaltiesScored",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "PenaltiesWon",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "RedCards",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "YellowCards",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "PlayersMatchStats");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayersMatchStats");

            migrationBuilder.DropColumn(
                name: "SeasonTeamId",
                table: "PlayersMatchStats");
        }
    }
}
