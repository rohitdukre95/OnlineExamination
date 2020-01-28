using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddDataIntoExperiance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ExperienceDescription", "ExperienceId", "IsActive", "LastUpdatedBy", "LastUpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 27, 19, 14, 15, 719, DateTimeKind.Local).AddTicks(7179), "< 2", 1, true, 1, new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ExperienceDescription", "ExperienceId", "IsActive", "LastUpdatedBy", "LastUpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2826), "2 OR < 4", 2, true, 1, new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ExperienceDescription", "ExperienceId", "IsActive", "LastUpdatedBy", "LastUpdatedOn" },
                values: new object[] { 3, 1, new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2838), "4 OR < 6", 3, true, 1, new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2842) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
