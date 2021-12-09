using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "76ef5f4c-d110-4e05-bdc3-cc602ffc3eb8", "katpog2001@gmail.com", "KATPOG2001@GMAIL.COM", "AQAAAAEAACcQAAAAEPUdz2kT7vSS5b+38vg6WjlCC/BBJInOjDwgPAQ3Kg0yES5+EgLN2Kj25gBYy23DHA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(8));

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

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"), "PageNews", new DateTime(2021, 12, 9, 9, 28, 31, 422, DateTimeKind.Utc).AddTicks(2015), null, null, null, null, "Содержание заполняется администратором", "Новости", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsItems");

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"));

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "dac40c96-0222-4564-ada3-346d895b9c4a", "my@email.com", "MY@EMAIL.COM", "AQAAAAEAACcQAAAAECR2FbDKe39qCK/Is8nFC1GaEEG5hdN9/HDoHUn1SdzfIUg4snb3t9VHEyFc97FtVA==" });

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
    }
}
