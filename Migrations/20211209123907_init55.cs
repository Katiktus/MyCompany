using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class init55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "NewsItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "cd0d518c-cae7-49f0-ab80-bdc228ffad4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ee5c926-63e5-43a7-a8e8-d4ff48838c13", "AQAAAAEAACcQAAAAEJXdZ3EZeqOAZacL8johR8eZI03z373HOmtWXNbrXE39M7lUzuXONxNLbmD7BT8zDw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 12, 39, 7, 102, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 12, 39, 7, 103, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 12, 39, 7, 103, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 12, 39, 7, 103, DateTimeKind.Utc).AddTicks(1830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "NewsItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "03cbbff0-2d99-4855-b949-e33ce4898c70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76ef5f4c-d110-4e05-bdc3-cc602ffc3eb8", "AQAAAAEAACcQAAAAEPUdz2kT7vSS5b+38vg6WjlCC/BBJInOjDwgPAQ3Kg0yES5+EgLN2Kj25gBYy23DHA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(1909));
        }
    }
}
