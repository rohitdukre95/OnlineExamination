using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
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
                name: "IX_ExamSubmissionResults_PositionId",
                table: "ExamSubmissionResults",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmissionResults_Positions_PositionId",
                table: "ExamSubmissionResults",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissionResults_Positions_PositionId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamSubmissionResults_PositionId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "ExamSubmissionResults");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 249, DateTimeKind.Local).AddTicks(8547), new DateTime(2020, 1, 31, 14, 35, 54, 251, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 251, DateTimeKind.Local).AddTicks(5476), new DateTime(2020, 1, 31, 14, 35, 54, 251, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 251, DateTimeKind.Local).AddTicks(5518), new DateTime(2020, 1, 31, 14, 35, 54, 251, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8406), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8454), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8460), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8464), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8468), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(4809), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(4850), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ExperienceId", "IsActive", "IsEnabled", "LastUpdatedBy", "LastUpdatedOn", "Marks", "QuestionDescription" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(1981), 1, true, true, 1, new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(1988), 4f, "Write a program for print given number is even or odd." });
        }
    }
}
