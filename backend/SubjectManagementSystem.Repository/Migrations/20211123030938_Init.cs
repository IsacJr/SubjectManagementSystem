using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SubjectManagementSystem.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_field",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_field", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_institution",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    employer_identification_number = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    zip_code = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    id_field = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_institution", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_institution_tb_field_id_field",
                        column: x => x.id_field,
                        principalTable: "tb_field",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_subject",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    syllabus = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    id_field = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_subject", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_subject_tb_field_id_field",
                        column: x => x.id_field,
                        principalTable: "tb_field",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    type = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    birthday = table.Column<DateTime>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    id_institution = table.Column<int>(nullable: false),
                    profile_picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_user_tb_institution_id_institution",
                        column: x => x.id_institution,
                        principalTable: "tb_institution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_team",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(nullable: true),
                    id_mentor = table.Column<int>(nullable: false),
                    solution = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_team", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_team_tb_user_id_mentor",
                        column: x => x.id_mentor,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_user_field",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_user = table.Column<int>(nullable: false),
                    id_field = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user_field", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_user_field_tb_field_id_field",
                        column: x => x.id_field,
                        principalTable: "tb_field",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_user_field_tb_user_id_user",
                        column: x => x.id_user,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_user_team",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_user = table.Column<int>(nullable: false),
                    id_team = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user_team", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_user_team_tb_team_id_team",
                        column: x => x.id_team,
                        principalTable: "tb_team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_user_team_tb_user_id_user",
                        column: x => x.id_user,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_classroom",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    schedule = table.Column<string>(nullable: true),
                    room = table.Column<string>(nullable: true),
                    id_professor = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    semester = table.Column<string>(nullable: true),
                    spot = table.Column<int>(nullable: false),
                    class_plan = table.Column<string>(nullable: true),
                    id_subject = table.Column<int>(nullable: false),
                    ChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_classroom", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_classroom_tb_user_id_professor",
                        column: x => x.id_professor,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_classroom_tb_subject_id_subject",
                        column: x => x.id_subject,
                        principalTable: "tb_subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_challenge",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    caption = table.Column<string>(nullable: true),
                    id_institution = table.Column<int>(nullable: false),
                    id_field = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    material = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    id_in_charge = table.Column<int>(nullable: false),
                    id_creator = table.Column<int>(nullable: false),
                    id_classroom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_challenge", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_challenge_tb_classroom_id_classroom",
                        column: x => x.id_classroom,
                        principalTable: "tb_classroom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_challenge_tb_user_id_creator",
                        column: x => x.id_creator,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_challenge_tb_field_id_field",
                        column: x => x.id_field,
                        principalTable: "tb_field",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_challenge_tb_user_id_in_charge",
                        column: x => x.id_in_charge,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_challenge_tb_institution_id_institution",
                        column: x => x.id_institution,
                        principalTable: "tb_institution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_contract",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_challenge = table.Column<int>(nullable: false),
                    id_classroom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_contract", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_contract_tb_challenge_id_challenge",
                        column: x => x.id_challenge,
                        principalTable: "tb_challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_contract_tb_classroom_id_classroom",
                        column: x => x.id_classroom,
                        principalTable: "tb_classroom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_problem_challenge",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    id_challenge = table.Column<int>(nullable: false),
                    id_team = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_problem_challenge", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_problem_challenge_tb_challenge_id_challenge",
                        column: x => x.id_challenge,
                        principalTable: "tb_challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_problem_challenge_tb_team_id_team",
                        column: x => x.id_team,
                        principalTable: "tb_team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_report",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    challenge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_report", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_report_tb_challenge_challenge",
                        column: x => x.challenge,
                        principalTable: "tb_challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_classroom",
                table: "tb_challenge",
                column: "id_classroom");

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_creator",
                table: "tb_challenge",
                column: "id_creator",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_challenge_id_field",
                table: "tb_challenge",
                column: "id_field");

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

            migrationBuilder.CreateIndex(
                name: "IX_tb_classroom_ChallengeId",
                table: "tb_classroom",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_classroom_id_professor",
                table: "tb_classroom",
                column: "id_professor");

            migrationBuilder.CreateIndex(
                name: "IX_tb_classroom_id_subject",
                table: "tb_classroom",
                column: "id_subject");

            migrationBuilder.CreateIndex(
                name: "IX_tb_contract_id_challenge",
                table: "tb_contract",
                column: "id_challenge",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_contract_id_classroom",
                table: "tb_contract",
                column: "id_classroom");

            migrationBuilder.CreateIndex(
                name: "IX_tb_institution_id_field",
                table: "tb_institution",
                column: "id_field",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_problem_challenge_id_challenge",
                table: "tb_problem_challenge",
                column: "id_challenge");

            migrationBuilder.CreateIndex(
                name: "IX_tb_problem_challenge_id_team",
                table: "tb_problem_challenge",
                column: "id_team",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_report_challenge",
                table: "tb_report",
                column: "challenge");

            migrationBuilder.CreateIndex(
                name: "IX_tb_subject_id_field",
                table: "tb_subject",
                column: "id_field");

            migrationBuilder.CreateIndex(
                name: "IX_tb_team_id_mentor",
                table: "tb_team",
                column: "id_mentor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_id_institution",
                table: "tb_user",
                column: "id_institution",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_field_id_field",
                table: "tb_user_field",
                column: "id_field");

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_field_id_user",
                table: "tb_user_field",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_team_id_team",
                table: "tb_user_team",
                column: "id_team");

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_team_id_user",
                table: "tb_user_team",
                column: "id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_classroom_tb_challenge_ChallengeId",
                table: "tb_classroom",
                column: "ChallengeId",
                principalTable: "tb_challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_challenge_tb_classroom_id_classroom",
                table: "tb_challenge");

            migrationBuilder.DropTable(
                name: "tb_contract");

            migrationBuilder.DropTable(
                name: "tb_problem_challenge");

            migrationBuilder.DropTable(
                name: "tb_report");

            migrationBuilder.DropTable(
                name: "tb_user_field");

            migrationBuilder.DropTable(
                name: "tb_user_team");

            migrationBuilder.DropTable(
                name: "tb_team");

            migrationBuilder.DropTable(
                name: "tb_classroom");

            migrationBuilder.DropTable(
                name: "tb_challenge");

            migrationBuilder.DropTable(
                name: "tb_subject");

            migrationBuilder.DropTable(
                name: "tb_user");

            migrationBuilder.DropTable(
                name: "tb_institution");

            migrationBuilder.DropTable(
                name: "tb_field");
        }
    }
}
