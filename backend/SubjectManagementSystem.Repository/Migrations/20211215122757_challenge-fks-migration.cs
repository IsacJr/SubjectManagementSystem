using Microsoft.EntityFrameworkCore.Migrations;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class challengefksmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_creator",
                table: "tb_challenge");

            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_in_charge",
                table: "tb_challenge");

            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_institution",
                table: "tb_challenge");

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_creator",
                table: "tb_challenge",
                column: "id_creator");

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_in_charge",
                table: "tb_challenge",
                column: "id_in_charge");

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_institution",
                table: "tb_challenge",
                column: "id_institution");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_creator",
                table: "tb_challenge");

            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_in_charge",
                table: "tb_challenge");

            migrationBuilder.DropIndex(
                name: "IX_tb_challenge_id_institution",
                table: "tb_challenge");

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_creator",
                table: "tb_challenge",
                column: "id_creator",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_in_charge",
                table: "tb_challenge",
                column: "id_in_charge",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_institution",
                table: "tb_challenge",
                column: "id_institution",
                unique: true);
        }
    }
}
