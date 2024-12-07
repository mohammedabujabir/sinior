using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Citizens_CitizenId1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CitizenId1",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe1ced37-c4e2-4b7d-ae25-b0e3e825bab0", "5faae787-f199-4496-b4b4-7b25f3a641a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97062a1d-5fcb-4556-90e6-2fabfa4a83ac", "746a3da1-a6fd-4790-b58e-be008d8e3bfc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af9e047d-2f17-41ea-9f47-9897b3494027", "79f2c8a8-0ef2-460d-b0b3-3d8b0795b882" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97062a1d-5fcb-4556-90e6-2fabfa4a83ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af9e047d-2f17-41ea-9f47-9897b3494027");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1ced37-c4e2-4b7d-ae25-b0e3e825bab0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5faae787-f199-4496-b4b4-7b25f3a641a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "746a3da1-a6fd-4790-b58e-be008d8e3bfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79f2c8a8-0ef2-460d-b0b3-3d8b0795b882");

            migrationBuilder.DropColumn(
                name: "CitizenId1",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a3c5262-7857-481e-8ec0-1eee5e2f59e3", null, "User", "USER" },
                    { "437b60ee-0015-4123-80ca-a81319e4873a", null, "Admin", "ADMIN" },
                    { "9c8c20f2-4855-4376-ab51-8e7f5ca8aab5", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "53071ca6-f187-4c3f-a82f-b1b010e919a8", 0, null, "4cdc818e-1483-4333-8253-c20b2b935d9f", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEI6zGngPs/BFOs1/lDVMXF2mAw+qdfQMLdUDzifi+VikFIEH6zyxQRGV18xG0WWKRA==", null, false, "6a21010f-8021-4625-b93c-c2325b577c04", false, "superAdmin@gmail.com" },
                    { "64af8299-b3ef-4bb1-b5f8-b79d67a0b724", 0, null, "e0337b71-617b-4b13-81c9-a0c8af92da5c", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEH6Ib6pGKRSFX2WBeJVj5op3pCe1OyyWJxnapnD4PInvBxAsFfqJfG9+pMYBLhNHAg==", null, false, "33ddad07-7357-4c39-84b7-f34a1ff3c87a", false, "admin@gmail.com" },
                    { "8339de8f-3cba-4139-a810-7fb747b42f1f", 0, null, "4fb7712f-5b39-4643-b144-ffd7d345ba11", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEKMrLsUnjN0qSHXFJOSANtvezDxWragLfw6MPhEUVd/YbYPJC6Ih0plZlXcUW/5R6Q==", null, false, "e823c963-ae75-489e-9e4f-852829ef8221", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9c8c20f2-4855-4376-ab51-8e7f5ca8aab5", "53071ca6-f187-4c3f-a82f-b1b010e919a8" },
                    { "437b60ee-0015-4123-80ca-a81319e4873a", "64af8299-b3ef-4bb1-b5f8-b79d67a0b724" },
                    { "3a3c5262-7857-481e-8ec0-1eee5e2f59e3", "8339de8f-3cba-4139-a810-7fb747b42f1f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c8c20f2-4855-4376-ab51-8e7f5ca8aab5", "53071ca6-f187-4c3f-a82f-b1b010e919a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "437b60ee-0015-4123-80ca-a81319e4873a", "64af8299-b3ef-4bb1-b5f8-b79d67a0b724" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a3c5262-7857-481e-8ec0-1eee5e2f59e3", "8339de8f-3cba-4139-a810-7fb747b42f1f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3c5262-7857-481e-8ec0-1eee5e2f59e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "437b60ee-0015-4123-80ca-a81319e4873a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c8c20f2-4855-4376-ab51-8e7f5ca8aab5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53071ca6-f187-4c3f-a82f-b1b010e919a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64af8299-b3ef-4bb1-b5f8-b79d67a0b724");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8339de8f-3cba-4139-a810-7fb747b42f1f");

            migrationBuilder.AddColumn<int>(
                name: "CitizenId1",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97062a1d-5fcb-4556-90e6-2fabfa4a83ac", null, "Admin", "ADMIN" },
                    { "af9e047d-2f17-41ea-9f47-9897b3494027", null, "User", "USER" },
                    { "fe1ced37-c4e2-4b7d-ae25-b0e3e825bab0", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5faae787-f199-4496-b4b4-7b25f3a641a2", 0, null, "1b0803b6-0bb9-4769-ae7a-6a004fdd2100", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEOW1eW28pr59gAAawuTEWBxHZSNJY/Uvku32FReLu6GJ6SH4sGKG5ofT4wIK92yz3A==", null, false, "f27401d5-815c-4a8c-87d8-9bdeb38cdf09", false, "superAdmin@gmail.com" },
                    { "746a3da1-a6fd-4790-b58e-be008d8e3bfc", 0, null, "e04181ca-5cc1-4c53-bda4-83d3274cdb66", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEMrOzttoB8YdztKB3cJg7Q8JZCqDGZQqvrAQ49FbkIKUNZALh9PItlPebGTgqj3Seg==", null, false, "24062999-35a1-4a17-bc84-849645c33643", false, "admin@gmail.com" },
                    { "79f2c8a8-0ef2-460d-b0b3-3d8b0795b882", 0, null, "28c915c3-73f1-47e9-9391-e3a919a783e8", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEDJ/8MGtMEJ91pc8LS8FvVFMRUtFU8bdOYyh1yjYgxZp71ru65ZHNtuUKU5eiDrJ1w==", null, false, "c1152208-a81c-424b-b84f-f18259bfbe9c", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fe1ced37-c4e2-4b7d-ae25-b0e3e825bab0", "5faae787-f199-4496-b4b4-7b25f3a641a2" },
                    { "97062a1d-5fcb-4556-90e6-2fabfa4a83ac", "746a3da1-a6fd-4790-b58e-be008d8e3bfc" },
                    { "af9e047d-2f17-41ea-9f47-9897b3494027", "79f2c8a8-0ef2-460d-b0b3-3d8b0795b882" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CitizenId1",
                table: "Cars",
                column: "CitizenId1",
                unique: true,
                filter: "[CitizenId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Citizens_CitizenId1",
                table: "Cars",
                column: "CitizenId1",
                principalTable: "Citizens",
                principalColumn: "CitizenId");
        }
    }
}
