using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "35ec2c4f-63f5-4741-81f7-e2ef0d970105");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dac40c96-0222-4564-ada3-346d895b9c4a", "AQAAAAEAACcQAAAAECR2FbDKe39qCK/Is8nFC1GaEEG5hdN9/HDoHUn1SdzfIUg4snb3t9VHEyFc97FtVA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 22, 8, 7, 38, 608, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 22, 8, 7, 38, 608, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 22, 8, 7, 38, 608, DateTimeKind.Utc).AddTicks(3543));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "fc5caed4-0054-466f-a920-b2cb0fed121c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d035e9e-5e67-4a3e-a490-91186b783199", "AQAAAAEAACcQAAAAEPF1x0NfY4b5XyDW9SGyM/sIsaLgTXhkP18nQQtX3/IypG3d+mmelr/My2Svmry48Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 17, 10, 3, 55, 505, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 17, 10, 3, 55, 505, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 17, 10, 3, 55, 505, DateTimeKind.Utc).AddTicks(9050));
        }
    }
}
