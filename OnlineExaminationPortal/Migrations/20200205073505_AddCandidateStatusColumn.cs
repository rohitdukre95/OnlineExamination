using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddCandidateStatusColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidateStatus",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 5, 5, 260, DateTimeKind.Local).AddTicks(5948), new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2326), new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2339), new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2339), new DateTime(2020, 2, 5, 13, 5, 5, 261, DateTimeKind.Local).AddTicks(2339) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CandidateStatus",
                table: "Candidates");

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
    }
}
