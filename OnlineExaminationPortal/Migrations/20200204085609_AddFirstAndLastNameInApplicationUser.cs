using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddFirstAndLastNameInApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 310, DateTimeKind.Local).AddTicks(8558), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4054), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4066), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5654), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5674), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4862), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4872), new DateTime(2020, 2, 4, 14, 26, 9, 311, DateTimeKind.Local).AddTicks(4875) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 180, DateTimeKind.Local).AddTicks(5060), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2667), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2685), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5802), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5823), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5825), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5827), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5829), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4240), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4257), new DateTime(2020, 1, 31, 15, 33, 58, 181, DateTimeKind.Local).AddTicks(4258) });
        }
    }
}
