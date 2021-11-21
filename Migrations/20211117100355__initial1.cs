using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "ServiceItems",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "3d035e9e-5e67-4a3e-a490-91186b783199", "MY@EMAIL.COM", "AQAAAAEAACcQAAAAEPF1x0NfY4b5XyDW9SGyM/sIsaLgTXhkP18nQQtX3/IypG3d+mmelr/My2Svmry48Q==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "30ea8030-2f72-46e6-b819-4631dc6255f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "cbaf0944-6954-49b7-a0ea-22d16b1b5cf9", "MY@EMAIL>COM", "AQAAAAEAACcQAAAAEBfg58od8pTpG5YYaGK6IP8GtbhBjqnj5itUWdw/h1J5XcVxsRJKkDguUzO5CnfXZg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 12, 16, 12, 38, 785, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 12, 16, 12, 38, 785, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 12, 16, 12, 38, 785, DateTimeKind.Utc).AddTicks(3209));
        }
    }
}
