using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "af7a18be-2c08-4e3b-bbc4-f94eefc25919");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "c3263a02-8451-4bca-9d54-ac61e8361f10", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2c91ef-93e5-450a-bb80-fb597ebfe684", "AQAAAAEAACcQAAAAEGHKyFonx6SJK+TYiLX2QZpNzGSc91GLbDfXo15srhsAf7c/RNX/syhniqn+cDrtGg==", "8ed0e149-57d7-41cb-90f2-f68645c6cb4c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8bb4f37a-0475-40ef-9c27-3f9be4c83c28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7235da9-2071-430b-abf7-2f92d50e82a2", "AQAAAAEAACcQAAAAED0r6pkdJt56KGaquMXreSumdPpP5BhNBKfCR04uJB0Xpai7S3nMXSlniSA4iglGeg==", "8de47c1d-3d23-47b5-91aa-c57ed9a11b96" });
        }
    }
}
