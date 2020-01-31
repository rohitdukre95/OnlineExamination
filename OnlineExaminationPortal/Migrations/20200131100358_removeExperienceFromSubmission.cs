using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class removeExperienceFromSubmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissionResults_Experience_ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamSubmissionResults_ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 180, DateTimeKind.Local).AddTicks(5060), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2667), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2685), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5802), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5823), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5825), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5827), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5829), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4240), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4257), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4258) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "ExamSubmissionResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 512, DateTimeKind.Local).AddTicks(8225), new DateTime(2020, 1, 31, 15, 12, 12, 516, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 516, DateTimeKind.Local).AddTicks(8192), new DateTime(2020, 1, 31, 15, 12, 12, 516, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 516, DateTimeKind.Local).AddTicks(8227), new DateTime(2020, 1, 31, 15, 12, 12, 516, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3712), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3748), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3752), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3755), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3758), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(972), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(1002), new DateTime(2020, 1, 31, 15, 12, 12, 517, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubmissionResults_ExperienceId",
                table: "ExamSubmissionResults",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmissionResults_Experience_ExperienceId",
                table: "ExamSubmissionResults",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
