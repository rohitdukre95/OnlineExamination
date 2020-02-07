using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddColumnTokenInCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Candidates",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 12, 8, 16, 897, DateTimeKind.Local).AddTicks(6528), new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2550), new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2560), new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2563), new DateTime(2020, 2, 7, 12, 8, 16, 898, DateTimeKind.Local).AddTicks(2563) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Candidates");

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
    }
}
