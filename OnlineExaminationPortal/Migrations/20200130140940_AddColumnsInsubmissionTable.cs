using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddColumnsInsubmissionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Output",
                table: "ExamSubmissionResults",
                newName: "StatusLine");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "ExamSubmissionResults",
                newName: "StandardOutput");

            migrationBuilder.AddColumn<string>(
                name: "CommandLineArguments",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompileTimeOutput",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompilerOptions",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "ExamSubmissionResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PageNumber",
                table: "ExamSubmissionResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QuestionDescription",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SandboxMessage",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SourceCode",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StandardError",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StandardInput",
                table: "ExamSubmissionResults",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(2859), new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(9185), new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(9201), new DateTime(2020, 1, 30, 19, 39, 40, 144, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3645), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3661), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3664), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3664), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3664), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(2384), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(2396), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(1434), new DateTime(2020, 1, 30, 19, 39, 40, 145, DateTimeKind.Local).AddTicks(1437) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissionResults_Experience_ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamSubmissionResults_ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "CommandLineArguments",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "CompileTimeOutput",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "CompilerOptions",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "PageNumber",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "QuestionDescription",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "SandboxMessage",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "SourceCode",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "StandardError",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "StandardInput",
                table: "ExamSubmissionResults");

            migrationBuilder.RenameColumn(
                name: "StatusLine",
                table: "ExamSubmissionResults",
                newName: "Output");

            migrationBuilder.RenameColumn(
                name: "StandardOutput",
                table: "ExamSubmissionResults",
                newName: "Code");

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(1668), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8161), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2624), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1372), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1385), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(413), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(416) });
        }
    }
}
