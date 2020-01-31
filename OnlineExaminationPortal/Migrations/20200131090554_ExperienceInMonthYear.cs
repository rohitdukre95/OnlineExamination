using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class ExperienceInMonthYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Candidates");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceMonth",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceYear",
                table: "Candidates",
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

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(1981), new DateTime(2020, 1, 31, 14, 35, 54, 252, DateTimeKind.Local).AddTicks(1988) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceMonth",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ExperienceYear",
                table: "Candidates");

            migrationBuilder.AddColumn<float>(
                name: "ExperienceId",
                table: "Candidates",
                nullable: false,
                defaultValue: 0f);

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
        }
    }
}
