using Microsoft.EntityFrameworkCore.Migrations;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class FixNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_challenge_tb_classroom_id_classroom",
                table: "tb_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_challenge_tb_user_id_in_charge",
                table: "tb_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_classroom_tb_user_id_professor",
                table: "tb_classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_institution_tb_field_id_field",
                table: "tb_institution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_problem_challenge_tb_team_id_team",
                table: "tb_problem_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_subject_tb_field_id_field",
                table: "tb_subject");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_team_tb_user_id_mentor",
                table: "tb_team");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_user_tb_institution_id_institution",
                table: "tb_user");

            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "tb_user",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "state",
                table: "tb_user",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_institution",
                table: "tb_user",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_mentor",
                table: "tb_team",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_field",
                table: "tb_subject",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_team",
                table: "tb_problem_challenge",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_field",
                table: "tb_institution",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_professor",
                table: "tb_classroom",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_in_charge",
                table: "tb_challenge",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_classroom",
                table: "tb_challenge",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_challenge_tb_classroom_id_classroom",
                table: "tb_challenge",
                column: "id_classroom",
                principalTable: "tb_classroom",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_challenge_tb_user_id_in_charge",
                table: "tb_challenge",
                column: "id_in_charge",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_classroom_tb_user_id_professor",
                table: "tb_classroom",
                column: "id_professor",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_institution_tb_field_id_field",
                table: "tb_institution",
                column: "id_field",
                principalTable: "tb_field",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_problem_challenge_tb_team_id_team",
                table: "tb_problem_challenge",
                column: "id_team",
                principalTable: "tb_team",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_subject_tb_field_id_field",
                table: "tb_subject",
                column: "id_field",
                principalTable: "tb_field",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_team_tb_user_id_mentor",
                table: "tb_team",
                column: "id_mentor",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_user_tb_institution_id_institution",
                table: "tb_user",
                column: "id_institution",
                principalTable: "tb_institution",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_challenge_tb_classroom_id_classroom",
                table: "tb_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_challenge_tb_user_id_in_charge",
                table: "tb_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_classroom_tb_user_id_professor",
                table: "tb_classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_institution_tb_field_id_field",
                table: "tb_institution");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_problem_challenge_tb_team_id_team",
                table: "tb_problem_challenge");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_subject_tb_field_id_field",
                table: "tb_subject");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_team_tb_user_id_mentor",
                table: "tb_team");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_user_tb_institution_id_institution",
                table: "tb_user");

            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "tb_user",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "state",
                table: "tb_user",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_institution",
                table: "tb_user",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_mentor",
                table: "tb_team",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_field",
                table: "tb_subject",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_team",
                table: "tb_problem_challenge",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_field",
                table: "tb_institution",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_professor",
                table: "tb_classroom",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_in_charge",
                table: "tb_challenge",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_classroom",
                table: "tb_challenge",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_challenge_tb_classroom_id_classroom",
                table: "tb_challenge",
                column: "id_classroom",
                principalTable: "tb_classroom",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_challenge_tb_user_id_in_charge",
                table: "tb_challenge",
                column: "id_in_charge",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_classroom_tb_user_id_professor",
                table: "tb_classroom",
                column: "id_professor",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_institution_tb_field_id_field",
                table: "tb_institution",
                column: "id_field",
                principalTable: "tb_field",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_problem_challenge_tb_team_id_team",
                table: "tb_problem_challenge",
                column: "id_team",
                principalTable: "tb_team",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_subject_tb_field_id_field",
                table: "tb_subject",
                column: "id_field",
                principalTable: "tb_field",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_team_tb_user_id_mentor",
                table: "tb_team",
                column: "id_mentor",
                principalTable: "tb_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_user_tb_institution_id_institution",
                table: "tb_user",
                column: "id_institution",
                principalTable: "tb_institution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
