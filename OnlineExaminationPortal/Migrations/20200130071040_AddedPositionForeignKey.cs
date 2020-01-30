using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationPortal.Migrations
{
    public partial class AddedPositionForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PositionDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_PositionId",
                table: "Candidates",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_PositionId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Candidates");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
