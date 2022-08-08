using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaWebApp.DataAccess.Migrations
{
    public partial class picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 7, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 7, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 8, 7, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 8, 7, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 8, 8, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 8, 8, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 8, 8, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 8, 8, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 8, 9, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 8, 9, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 8, 9, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 8, 9, 17, 28, 7, 435, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Snack",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://images.unsplash.com/photo-1623179007436-1d366e78ba68?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 7, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 7, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 8, 7, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 8, 7, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 8, 8, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 8, 8, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 8, 8, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 8, 8, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 8, 9, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 8, 9, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 8, 9, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "MovieProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 8, 9, 15, 27, 48, 185, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Snack",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://images.unsplash.com/photo-1548867688-231911e4ba3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80");
        }
    }
}
