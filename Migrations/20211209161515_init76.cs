using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class init76 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "NewsItems",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "b2d2fe71-fb2a-41ce-a905-eaf9b31b852b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd623bcc-052e-4194-b8bf-85c2f40ad471", "AQAAAAEAACcQAAAAEGTqz2isWo/kpPm4h/phR1SfX+KgIAVZ2vyzdXyyKfX8vTuTwnJFjW+UxcDjJyEROg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 16, 15, 14, 953, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 16, 15, 14, 954, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 16, 15, 14, 954, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 16, 15, 14, 954, DateTimeKind.Utc).AddTicks(88));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "NewsItems");

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
    }
}
