using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddColumnIsExamClearedInCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExamCleared",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 39, 11, 701, DateTimeKind.Local).AddTicks(8602), new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4663), new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4676), new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4679), new DateTime(2020, 2, 5, 12, 39, 11, 702, DateTimeKind.Local).AddTicks(4679) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExamCleared",
                table: "Candidates");

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(820), new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6874), new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886), new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886), new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886) });
        }
    }
}
