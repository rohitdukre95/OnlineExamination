using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddCandidateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    CurrentCompany = table.Column<string>(nullable: true),
                    ExperienceId = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");

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

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(9123), new DateTime(2020, 1, 27, 20, 16, 54, 32, DateTimeKind.Local).AddTicks(9123) });
        }
    }
}
