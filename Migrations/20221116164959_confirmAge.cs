using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DidacticVerse.Migrations
{
    public partial class confirmAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Accounts");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmAge",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Created",
                value: new DateTime(2022, 11, 16, 11, 49, 59, 715, DateTimeKind.Local).AddTicks(6018));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmAge",
                table: "Accounts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Created",
                value: new DateTime(2022, 11, 7, 0, 12, 6, 771, DateTimeKind.Local).AddTicks(4697));
        }
    }
}
