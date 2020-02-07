using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddColumnExamLinkAndIsConsumedInCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExamLink",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsConsumed",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(872), new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6384), new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6394), new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6397), new DateTime(2020, 2, 7, 11, 44, 58, 999, DateTimeKind.Local).AddTicks(6397) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamLink",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IsConsumed",
                table: "Candidates");

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 6, 16, 37, 35, 94, DateTimeKind.Local).AddTicks(9725), new DateTime(2020, 2, 6, 16, 37, 35, 95, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(135), new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(165), new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(169), new DateTime(2020, 2, 6, 16, 37, 35, 96, DateTimeKind.Local).AddTicks(170) });
        }
    }
}
