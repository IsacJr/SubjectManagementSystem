using Microsoft.EntityFrameworkCore.Migrations;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class teamusermigrationadjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tb_team_id_mentor",
                table: "tb_team");

            migrationBuilder.CreateIndex(
                name: "IX_tb_team_id_mentor",
                table: "tb_team",
                column: "id_mentor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tb_team_id_mentor",
                table: "tb_team");

            migrationBuilder.CreateIndex(
                name: "IX_tb_team_id_mentor",
                table: "tb_team",
                column: "id_mentor",
                unique: true);
        }
    }
}
