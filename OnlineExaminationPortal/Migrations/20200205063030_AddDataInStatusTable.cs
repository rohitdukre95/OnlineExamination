using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddDataInStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(820), true, new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6874), true, new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886), true, new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886), true, new DateTime(2020, 2, 5, 12, 0, 30, 310, DateTimeKind.Local).AddTicks(6886) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IsActive", "LastUpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
