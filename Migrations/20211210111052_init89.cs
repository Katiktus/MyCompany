using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class init89 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("d555fe3b-7c9b-42f2-958a-b505382e619d"), "PageMessages", new DateTime(2021, 12, 10, 11, 10, 51, 676, DateTimeKind.Utc).AddTicks(8009), null, null, null, null, "Содержание заполняется администратором", "Обратная связь", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d555fe3b-7c9b-42f2-958a-b505382e619d"));

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
    }
}
