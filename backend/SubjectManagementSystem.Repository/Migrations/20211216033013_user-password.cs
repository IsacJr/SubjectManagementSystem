using Microsoft.EntityFrameworkCore.Migrations;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class userpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Solution_tb_problem_challenge_id_problem",
                table: "tb_Solution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Solution_tb_team_id_team",
                table: "tb_Solution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_stage_tb_Solution_id_solution",
                table: "tb_stage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Solution",
                table: "tb_Solution");

            migrationBuilder.RenameTable(
                name: "tb_Solution",
                newName: "tb_solution");

            migrationBuilder.RenameIndex(
                name: "IX_tb_Solution_id_team",
                table: "tb_solution",
                newName: "IX_tb_solution_id_team");

            migrationBuilder.RenameIndex(
                name: "IX_tb_Solution_id_problem",
                table: "tb_solution",
                newName: "IX_tb_solution_id_problem");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "tb_user",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_solution",
                table: "tb_solution",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_solution_tb_problem_challenge_id_problem",
                table: "tb_solution",
                column: "id_problem",
                principalTable: "tb_problem_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_solution_tb_team_id_team",
                table: "tb_solution",
                column: "id_team",
                principalTable: "tb_team",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_stage_tb_solution_id_solution",
                table: "tb_stage",
                column: "id_solution",
                principalTable: "tb_solution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_solution_tb_problem_challenge_id_problem",
                table: "tb_solution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_solution_tb_team_id_team",
                table: "tb_solution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_stage_tb_solution_id_solution",
                table: "tb_stage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_solution",
                table: "tb_solution");

            migrationBuilder.DropColumn(
                name: "password",
                table: "tb_user");

            migrationBuilder.RenameTable(
                name: "tb_solution",
                newName: "tb_Solution");

            migrationBuilder.RenameIndex(
                name: "IX_tb_solution_id_team",
                table: "tb_Solution",
                newName: "IX_tb_Solution_id_team");

            migrationBuilder.RenameIndex(
                name: "IX_tb_solution_id_problem",
                table: "tb_Solution",
                newName: "IX_tb_Solution_id_problem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Solution",
                table: "tb_Solution",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Solution_tb_problem_challenge_id_problem",
                table: "tb_Solution",
                column: "id_problem",
                principalTable: "tb_problem_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Solution_tb_team_id_team",
                table: "tb_Solution",
                column: "id_team",
                principalTable: "tb_team",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_stage_tb_Solution_id_solution",
                table: "tb_stage",
                column: "id_solution",
                principalTable: "tb_Solution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
