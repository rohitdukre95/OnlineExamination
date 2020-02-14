using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class removeLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(1235), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6499), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "CandidateStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512), new DateTime(2020, 2, 13, 18, 58, 5, 688, DateTimeKind.Local).AddTicks(6512) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

          
            

          
        }
    }
}
