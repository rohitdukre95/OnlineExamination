using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddDataIntoQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(2130), new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(7737), new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(7750), new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ExperienceId", "IsActive", "IsEnabled", "LastUpdatedBy", "LastUpdatedOn", "Marks", "QuestionDescription" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(9123), 1, true, true, 1, new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(9123), 4f, "Write a program for print given number is even or odd." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 19, 14, 15, 719, DateTimeKind.Local).AddTicks(7179), new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2826), new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2838), new DateTime(2020, 1, 27, 19, 14, 15, 720, DateTimeKind.Local).AddTicks(2842) });
        }
    }
}
