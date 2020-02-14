using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddedLangIdAndName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "ExamSubmissionResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "ExamSubmissionResults",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "ExamSubmissionResults");

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(1235), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6499), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512) });
        }
    }
}
