using Microsoft.EntityFrameworkCore.Migrations;

namespace Dao.Migrations
{
    public partial class changed_table_league : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Leagues");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Leagues",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Leagues");

            migrationBuilder.AddColumn<int>(
                name: "Discription",
                table: "Leagues",
                nullable: false,
                defaultValue: 0);
        }
    }
}
