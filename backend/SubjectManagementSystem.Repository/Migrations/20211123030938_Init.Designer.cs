﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SubjectManagementSystem.Repository;

namespace SubjectManagementSystem.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211123030938_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SubjectManagementSystem.Domain.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Caption")
                        .HasColumnName("caption")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int>("IdClassroom")
                        .HasColumnName("id_classroom")
                        .HasColumnType("integer");

                    b.Property<int>("IdCreator")
                        .HasColumnName("id_creator")
                        .HasColumnType("integer");

                    b.Property<int>("IdField")
                        .HasColumnName("id_field")
                        .HasColumnType("integer");

                    b.Property<int>("IdInCharge")
                        .HasColumnName("id_in_charge")
                        .HasColumnType("integer");

                    b.Property<int>("IdInstitution")
                        .HasColumnName("id_institution")
                        .HasColumnType("integer");

                    b.Property<string>("Material")
                        .HasColumnName("material")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnName("status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdClassroom");

                    b.HasIndex("IdCreator")
                        .IsUnique();

                    b.HasIndex("IdField");

                    b.HasIndex("IdInCharge")
                        .IsUnique();

                    b.HasIndex("IdInstitution")
                        .IsUnique();

                    b.ToTable("tb_challenge");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ChallengeId")
                        .HasColumnType("integer");

                    b.Property<string>("ClassPlan")
                        .HasColumnName("class_plan")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnName("end_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdProfessor")
                        .HasColumnName("id_professor")
                        .HasColumnType("integer");

                    b.Property<int>("IdSubject")
                        .HasColumnName("id_subject")
                        .HasColumnType("integer");

                    b.Property<string>("Room")
                        .HasColumnName("room")
                        .HasColumnType("text");

                    b.Property<string>("Schedule")
                        .HasColumnName("schedule")
                        .HasColumnType("text");

                    b.Property<string>("Semester")
                        .HasColumnName("semester")
                        .HasColumnType("text");

                    b.Property<int>("Spot")
                        .HasColumnName("spot")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Year")
                        .HasColumnName("year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("IdProfessor");

                    b.HasIndex("IdSubject");

                    b.ToTable("tb_classroom");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("IdChallenge")
                        .HasColumnName("id_challenge")
                        .HasColumnType("integer");

                    b.Property<int>("IdClassroom")
                        .HasColumnName("id_classroom")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdChallenge")
                        .IsUnique();

                    b.HasIndex("IdClassroom");

                    b.ToTable("tb_contract");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_field");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<string>("EmployerIdentificationNumber")
                        .HasColumnName("employer_identification_number")
                        .HasColumnType("text");

                    b.Property<int>("IdField")
                        .HasColumnName("id_field")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnName("state")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnName("street")
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .HasColumnName("zip_code")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdField")
                        .IsUnique();

                    b.ToTable("tb_institution");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.ProblemChallenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<string>("Detail")
                        .HasColumnName("detail")
                        .HasColumnType("text");

                    b.Property<int>("IdChallenge")
                        .HasColumnName("id_challenge")
                        .HasColumnType("integer");

                    b.Property<int>("IdTeam")
                        .HasColumnName("id_team")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdChallenge");

                    b.HasIndex("IdTeam")
                        .IsUnique();

                    b.ToTable("tb_problem_challenge");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int>("IdChallenge")
                        .HasColumnName("challenge")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdChallenge");

                    b.ToTable("tb_report");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<int>("IdField")
                        .HasColumnName("id_field")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnName("level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Syllabus")
                        .HasColumnName("syllabus")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdField");

                    b.ToTable("tb_subject");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.Property<int>("IdMentor")
                        .HasColumnName("id_mentor")
                        .HasColumnType("integer");

                    b.Property<string>("Solution")
                        .HasColumnName("solution")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdMentor")
                        .IsUnique();

                    b.ToTable("tb_team");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnName("birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<int>("IdInstitution")
                        .HasColumnName("id_institution")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("ProfilePicture")
                        .HasColumnName("profile_picture")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnName("state")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnName("type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdInstitution")
                        .IsUnique();

                    b.ToTable("tb_user");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.UserField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("IdField")
                        .HasColumnName("id_field")
                        .HasColumnType("integer");

                    b.Property<int>("IdUser")
                        .HasColumnName("id_user")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdField");

                    b.HasIndex("IdUser");

                    b.ToTable("tb_user_field");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.UserTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("IdTeam")
                        .HasColumnName("id_team")
                        .HasColumnType("integer");

                    b.Property<int>("IdUser")
                        .HasColumnName("id_user")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdTeam");

                    b.HasIndex("IdUser");

                    b.ToTable("tb_user_team");
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Challenge", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("IdClassroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.User", "Creator")
                        .WithOne("ChallengeCreator")
                        .HasForeignKey("SubjectManagementSystem.Domain.Challenge", "IdCreator")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.Field", "Field")
                        .WithMany()
                        .HasForeignKey("IdField")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.User", "InCharge")
                        .WithOne("ChallengeInCharge")
                        .HasForeignKey("SubjectManagementSystem.Domain.Challenge", "IdInCharge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.Institution", "Institution")
                        .WithOne("Challenge")
                        .HasForeignKey("SubjectManagementSystem.Domain.Challenge", "IdInstitution")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Classroom", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId");

                    b.HasOne("SubjectManagementSystem.Domain.User", "Professor")
                        .WithMany()
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("IdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Contract", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Challenge", "Challenge")
                        .WithOne("Contract")
                        .HasForeignKey("SubjectManagementSystem.Domain.Contract", "IdChallenge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("IdClassroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Institution", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Field", "Field")
                        .WithOne("Institution")
                        .HasForeignKey("SubjectManagementSystem.Domain.Institution", "IdField")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.ProblemChallenge", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("IdChallenge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.Team", "Team")
                        .WithOne("ProblemChallenge")
                        .HasForeignKey("SubjectManagementSystem.Domain.ProblemChallenge", "IdTeam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Report", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("IdChallenge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Subject", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Field", "Field")
                        .WithMany()
                        .HasForeignKey("IdField")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.Team", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.User", "Mentor")
                        .WithOne("Team")
                        .HasForeignKey("SubjectManagementSystem.Domain.Team", "IdMentor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.User", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Institution", "Institution")
                        .WithOne("User")
                        .HasForeignKey("SubjectManagementSystem.Domain.User", "IdInstitution")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.UserField", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Field", "Field")
                        .WithMany()
                        .HasForeignKey("IdField")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.User", "User")
                        .WithMany("Fields")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectManagementSystem.Domain.UserTeam", b =>
                {
                    b.HasOne("SubjectManagementSystem.Domain.Team", "Team")
                        .WithMany("Members")
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubjectManagementSystem.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
