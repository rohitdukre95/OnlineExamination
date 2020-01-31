using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class addlanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "ExamSubmissionResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LanguageList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageList", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "LanguageList",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Language", "LanguageId", "LastUpdatedBy", "LastUpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(9872), true, "C#", 51, 1, new DateTime(2020, 1, 30, 15, 20, 48, 889, DateTimeKind.Local).AddTicks(9875) });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubmissionResults_LanguageId",
                table: "ExamSubmissionResults",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmissionResults_LanguageList_LanguageId",
                table: "ExamSubmissionResults",
                column: "LanguageId",
                principalTable: "LanguageList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissionResults_LanguageList_LanguageId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropTable(
                name: "LanguageList");

            migrationBuilder.DropIndex(
                name: "IX_ExamSubmissionResults_LanguageId",
                table: "ExamSubmissionResults");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ExamSubmissionResults");

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

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5812), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5829), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(4617), new DateTime(2020, 1, 30, 12, 47, 39, 797, DateTimeKind.Local).AddTicks(4621) });
        }
    }
}
