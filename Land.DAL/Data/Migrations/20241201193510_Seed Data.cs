using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f6d2745-6ff6-43c5-b9e8-0fa79c0df77c", null, "Admin", "ADMIN" },
                    { "500cccef-7562-4894-9df2-2f386fa037e3", null, "User", "USER" },
                    { "e71bf4a3-6f01-4901-8d89-9720c94724b9", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "66cbd1f8-dd01-42f9-baf5-685b5ea318c7", 0, null, "b31568c0-8195-4536-a06f-ff4fb9bebc7b", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEGfO92MsqUFaSQPseUhCB5EZCn93C8H8iVcD/Nby95xWADbFaVyy+PVwdZIMB7+hZA==", null, false, "b0ceab33-31f9-45f8-b257-7c3fcdaa1097", false, "superAdmin@gmail.com" },
                    { "d5f9fd57-1047-4357-98fa-629314f4aa80", 0, null, "44f47cc6-03c3-43a1-b8cf-cc560a272186", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEOdtDbIaSWJljqDwq9hBM4fVHlFv3I2ljdb2C6/+w9UiI4Heb6z+b/Zfhf/o+44XTw==", null, false, "4daa9d66-973a-4155-8358-d0de17b82564", false, "admin@gmail.com" },
                    { "fa6f4bf9-9857-4c30-9e74-0c67d297d2ec", 0, null, "12df96fd-064f-4a17-8279-148c6e9add6a", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEARLA0N9XxSZk/IKJs1XK1UmCEcDYfzbOLyPM4eB95zpZxmYgGqFjcMJdkVgy7Zl8w==", null, false, "52d68205-4194-4b71-b5c7-425d68cb4d85", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e71bf4a3-6f01-4901-8d89-9720c94724b9", "66cbd1f8-dd01-42f9-baf5-685b5ea318c7" },
                    { "2f6d2745-6ff6-43c5-b9e8-0fa79c0df77c", "d5f9fd57-1047-4357-98fa-629314f4aa80" },
                    { "500cccef-7562-4894-9df2-2f386fa037e3", "fa6f4bf9-9857-4c30-9e74-0c67d297d2ec" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e71bf4a3-6f01-4901-8d89-9720c94724b9", "66cbd1f8-dd01-42f9-baf5-685b5ea318c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f6d2745-6ff6-43c5-b9e8-0fa79c0df77c", "d5f9fd57-1047-4357-98fa-629314f4aa80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "500cccef-7562-4894-9df2-2f386fa037e3", "fa6f4bf9-9857-4c30-9e74-0c67d297d2ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f6d2745-6ff6-43c5-b9e8-0fa79c0df77c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "500cccef-7562-4894-9df2-2f386fa037e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e71bf4a3-6f01-4901-8d89-9720c94724b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66cbd1f8-dd01-42f9-baf5-685b5ea318c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5f9fd57-1047-4357-98fa-629314f4aa80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa6f4bf9-9857-4c30-9e74-0c67d297d2ec");
        }
    }
}
