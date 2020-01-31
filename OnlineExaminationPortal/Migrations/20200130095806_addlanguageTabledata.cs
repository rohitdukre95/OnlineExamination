using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class addlanguageTabledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(1668), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8161), new DateTime(2020, 1, 30, 15, 28, 6, 38, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2624), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.InsertData(
                table: "LanguageList",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Language", "LanguageId", "LastUpdatedBy", "LastUpdatedOn" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), true, "C", 50, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640) },
                    { 3, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), true, "C++", 54, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640) },
                    { 4, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2640), true, "Java", 62, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643) },
                    { 5, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643), true, "Python", 71, 1, new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(2643) }
                });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1372), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1385), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(413), new DateTime(2020, 1, 30, 15, 28, 6, 39, DateTimeKind.Local).AddTicks(416) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 888, DateTimeKind.Local).AddTicks(9106), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(5435), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(5451), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "LanguageList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(9872), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(8621), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(8634), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(7671), new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(7671) });
        }
    }
}
