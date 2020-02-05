﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineExaminationPortal.Models;

namespace OnlineExaminationPortal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200205070911_AddColumnIsExamClearedInCandidate")]
    partial class AddColumnIsExamClearedInCandidate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("CurrentCompany");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("ExperienceMonth");

                    b.Property<int>("ExperienceYear");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsExamCleared");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.CandidateStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CandidateStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 701, DateTimeKind.Local).AddTicks(8602),
                            IsActive = true,
                            LastUpdatedBy = 1,
                            LastUpdatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(3890),
                            Status = "Candidate Registered"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4663),
                            IsActive = true,
                            LastUpdatedBy = 1,
                            LastUpdatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4669),
                            Status = "Allowed for Exam"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4676),
                            IsActive = true,
                            LastUpdatedBy = 1,
                            LastUpdatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4676),
                            Status = "Exam In Progress"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4679),
                            IsActive = true,
                            LastUpdatedBy = 1,
                            LastUpdatedOn = new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4679),
                            Status = "Exam Completed"
                        });
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.ExamSubmissionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId");

                    b.Property<string>("CommandLineArguments");

                    b.Property<string>("CompileTimeOutput");

                    b.Property<string>("CompilerOptions");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LanguageId");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<int>("PageNumber");

                    b.Property<int>("PositionId");

                    b.Property<string>("QuestionDescription");

                    b.Property<int>("QuestionNumber");

                    b.Property<string>("SandboxMessage");

                    b.Property<string>("SourceCode");

                    b.Property<string>("StandardError");

                    b.Property<string>("StandardInput");

                    b.Property<string>("StandardOutput");

                    b.Property<string>("StatusLine");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PositionId");

                    b.ToTable("ExamSubmissionResults");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("ExperienceDescription")
                        .IsRequired();

                    b.Property<int>("ExperienceId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.LanguageMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Language");

                    b.Property<int>("LanguageId");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("LanguageList");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("PositionDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<float?>("Marks")
                        .IsRequired();

                    b.Property<int>("PositionId");

                    b.Property<string>("QuestionDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineExaminationPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineExaminationPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnlineExaminationPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineExaminationPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.Candidate", b =>
                {
                    b.HasOne("OnlineExaminationPortal.Models.Position", "Position")
                        .WithMany("Candidates")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnlineExaminationPortal.Models.ExamSubmissionResult", b =>
                {
                    b.HasOne("OnlineExaminationPortal.Models.LanguageMaster", "LanguageRef")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnlineExaminationPortal.Models.Position", "PositionRef")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
