using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddDataIntoPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 796, DateTimeKind.Local).AddTicks(3631), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(1735), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(1753), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "LastUpdatedBy", "LastUpdatedOn", "PositionDescription" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5812), true, 1, new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5814), "Trainee Software Developer" },
                    { 2, 1, new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5829), true, 1, new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5830), "Software Developer" }
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(4617), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(4621) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 40, 39, 977, DateTimeKind.Local).AddTicks(6850), new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(4881), new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(4899), new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(7749), new DateTime(2020, 1, 30, 12, 40, 39, 978, DateTimeKind.Local).AddTicks(7752) });
        }
    }
}
