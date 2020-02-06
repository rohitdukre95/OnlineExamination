using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class MarksColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Marks",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marks",
                table: "Candidates");

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 19, 22, 44, 972, DateTimeKind.Local).AddTicks(5541), new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4440), new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4461), new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4463), new DateTime(2020, 2, 5, 19, 22, 44, 973, DateTimeKind.Local).AddTicks(4464) });
        }
    }
}
