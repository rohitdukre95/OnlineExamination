using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddExamSubmissionResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamSubmissionResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false),
                    QuestionNumber = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Output = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSubmissionResults", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(8891), new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(8904), new DateTime(2020, 1, 28, 19, 11, 6, 891, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 19, 11, 6, 892, DateTimeKind.Local).AddTicks(1342), new DateTime(2020, 1, 28, 19, 11, 6, 892, DateTimeKind.Local).AddTicks(1342) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamSubmissionResults");

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(3014), new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(9147), new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(9160), new DateTime(2020, 1, 28, 16, 46, 17, 983, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 28, 16, 46, 17, 984, DateTimeKind.Local).AddTicks(1364), new DateTime(2020, 1, 28, 16, 46, 17, 984, DateTimeKind.Local).AddTicks(1364) });
        }
    }
}
