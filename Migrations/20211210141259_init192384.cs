using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class init192384 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "NewsItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChanged",
                table: "NewsItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "From",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "357f09c2-faa4-420a-8591-557dcdd08824");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "904f4559-2333-4ac8-af3c-ae865299ef66", "AQAAAAEAACcQAAAAEBkwLyqAU90KYb5/2X4DGmYRJ1qw7E1WpUuLRG15Z9I03AqQKBhldFM0p2ra69ohwg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 14, 12, 58, 474, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 14, 12, 58, 474, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 14, 12, 58, 474, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 14, 12, 58, 474, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d555fe3b-7c9b-42f2-958a-b505382e619d"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 14, 12, 58, 474, DateTimeKind.Utc).AddTicks(8139));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChanged",
                table: "NewsItems");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "From",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                column: "ConcurrencyStamp",
                value: "6f3b46e3-40a6-4dc8-864c-7662a55a1bd3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6812dc5-6576-481a-848c-33f7baa631f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06fedf24-b35d-4913-94db-f900571faa08", "AQAAAAEAACcQAAAAEFxE8UxSkVT5b8FI8Z2TzqNV0lvd9CoVIg0H39EafjYWasg0wdy5VNK9CN9h4ggfuw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d555fe3b-7c9b-42f2-958a-b505382e619d"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(8009));
        }
    }
}
