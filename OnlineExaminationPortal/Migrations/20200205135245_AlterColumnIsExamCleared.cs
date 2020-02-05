using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AlterColumnIsExamCleared : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsExamCleared",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(bool));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsExamCleared",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int));

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
    }
}
