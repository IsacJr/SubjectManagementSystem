using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class AddSolutionAndStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_report_tb_challenge_challenge",
                table: "tb_report");

            migrationBuilder.RenameColumn(
                name: "challenge",
                table: "tb_report",
                newName: "id_challenge");

            migrationBuilder.RenameIndex(
                name: "IX_tb_report_challenge",
                table: "tb_report",
                newName: "IX_tb_report_id_challenge");

            migrationBuilder.AddColumn<int>(
                name: "id_author",
                table: "tb_report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_Solution",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_problem = table.Column<int>(nullable: false),
                    id_team = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Solution", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_Solution_tb_problem_challenge_id_problem",
                        column: x => x.id_problem,
                        principalTable: "tb_problem_challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Solution_tb_team_id_team",
                        column: x => x.id_team,
                        principalTable: "tb_team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_stage",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true),
                    id_solution = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_stage", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_stage_tb_Solution_id_solution",
                        column: x => x.id_solution,
                        principalTable: "tb_Solution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_report_id_author",
                table: "tb_report",
                column: "id_author");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Solution_id_problem",
                table: "tb_Solution",
                column: "id_problem",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Solution_id_team",
                table: "tb_Solution",
                column: "id_team");

            migrationBuilder.CreateIndex(
                name: "IX_tb_stage_id_solution",
                table: "tb_stage",
                column: "id_solution");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_report_tb_user_id_author",
                table: "tb_report",
                column: "id_author",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_report_tb_challenge_id_challenge",
                table: "tb_report",
                column: "id_challenge",
                principalTable: "tb_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_report_tb_user_id_author",
                table: "tb_report");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_report_tb_challenge_id_challenge",
                table: "tb_report");

            migrationBuilder.DropTable(
                name: "tb_stage");

            migrationBuilder.DropTable(
                name: "tb_Solution");

            migrationBuilder.DropIndex(
                name: "IX_tb_report_id_author",
                table: "tb_report");

            migrationBuilder.DropColumn(
                name: "id_author",
                table: "tb_report");

            migrationBuilder.RenameColumn(
                name: "id_challenge",
                table: "tb_report",
                newName: "challenge");

            migrationBuilder.RenameIndex(
                name: "IX_tb_report_id_challenge",
                table: "tb_report",
                newName: "IX_tb_report_challenge");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_report_tb_challenge_challenge",
                table: "tb_report",
                column: "challenge",
                principalTable: "tb_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
