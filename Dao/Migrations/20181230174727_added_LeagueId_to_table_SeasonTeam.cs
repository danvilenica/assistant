using Microsoft.EntityFrameworkCore.Migrations;

namespace Dao.Migrations
{
    public partial class added_LeagueId_to_table_SeasonTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "SeasonTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SeasonTeams_LeagueId",
                table: "SeasonTeams",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonTeams_Seasons_LeagueId",
                table: "SeasonTeams",
                column: "LeagueId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonTeams_Seasons_LeagueId",
                table: "SeasonTeams");

            migrationBuilder.DropIndex(
                name: "IX_SeasonTeams_LeagueId",
                table: "SeasonTeams");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "SeasonTeams");
        }
    }
}
