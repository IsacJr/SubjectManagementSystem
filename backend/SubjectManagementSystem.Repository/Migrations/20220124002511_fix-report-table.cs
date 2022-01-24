using Microsoft.EntityFrameworkCore.Migrations;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class fixreporttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_report_tb_challenge_id_challenge",
                table: "tb_report");

            migrationBuilder.DropIndex(
                name: "IX_tb_report_id_challenge",
                table: "tb_report");

            migrationBuilder.DropColumn(
                name: "id_challenge",
                table: "tb_report");

            migrationBuilder.AddColumn<int>(
                name: "id_problem_challenge",
                table: "tb_report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_report_id_problem_challenge",
                table: "tb_report",
                column: "id_problem_challenge");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_report_tb_problem_challenge_id_problem_challenge",
                table: "tb_report",
                column: "id_problem_challenge",
                principalTable: "tb_problem_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_report_tb_problem_challenge_id_problem_challenge",
                table: "tb_report");

            migrationBuilder.DropIndex(
                name: "IX_tb_report_id_problem_challenge",
                table: "tb_report");

            migrationBuilder.DropColumn(
                name: "id_problem_challenge",
                table: "tb_report");

            migrationBuilder.AddColumn<int>(
                name: "id_challenge",
                table: "tb_report",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_report_id_challenge",
                table: "tb_report",
                column: "id_challenge");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_report_tb_challenge_id_challenge",
                table: "tb_report",
                column: "id_challenge",
                principalTable: "tb_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
