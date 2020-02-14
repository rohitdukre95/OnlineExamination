using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddTalesMCQQuestionsAndMCQSubmissionResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MCQQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Question = table.Column<string>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCQQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MCQSubmissionResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    CorrectAnswer = table.Column<int>(nullable: false),
                    SelectedAnswer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCQSubmissionResult", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(2441), new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8443), new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8453), new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8456), new DateTime(2020, 2, 14, 15, 57, 30, 304, DateTimeKind.Local).AddTicks(8456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MCQQuestions");

            migrationBuilder.DropTable(
                name: "MCQSubmissionResult");

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 19, 7, 53, 501, DateTimeKind.Local).AddTicks(7127), new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2458), new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2471), new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2471), new DateTime(2020, 2, 13, 19, 7, 53, 502, DateTimeKind.Local).AddTicks(2471) });
        }
    }
}
