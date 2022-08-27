using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaWebApp.DataAccess.Migrations
{
    public partial class smalldescchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "In the 1970s, young Gru tries to join a group of supervillains called the Vicious 6 after they oust their leader -- the legendary fighter Wild Knuckles. When the interview turns disastrous, Gru and his Minions go on the run with the Vicious 6 hot on their tails. Luckily, he finds an unlikely source for guidance -- Wild Knuckles himself -- and soon discovers that even bad guys need a little help from their friends.");

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 27, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 27, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 8, 27, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 8, 27, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 8, 28, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 8, 28, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 8, 28, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 8, 28, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 8, 29, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 8, 29, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 8, 29, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 8, 29, 9, 57, 47, 253, DateTimeKind.Local).AddTicks(5024));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "n the 1970s, young Gru tries to join a group of supervillains called the Vicious 6 after they oust their leader -- the legendary fighter Wild Knuckles. When the interview turns disastrous, Gru and his Minions go on the run with the Vicious 6 hot on their tails. Luckily, he finds an unlikely source for guidance -- Wild Knuckles himself -- and soon discovers that even bad guys need a little help from their friends.");

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
    }
}
