using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaWebApp.DataAccess.Migrations
{
    public partial class snackorderprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SnackOrder",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SnackOrder");

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 8, 11, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 8, 12, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 8, 13, 23, 0, 6, 938, DateTimeKind.Local).AddTicks(2993));
        }
    }
}
