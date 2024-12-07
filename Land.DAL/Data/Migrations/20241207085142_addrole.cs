using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class addrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "658006f0-6da4-43db-bdff-88e5c242cb1b", "06687f64-7673-4a0d-8837-55cd90e220f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd388a39-003c-4535-839a-e7009506ef1a", "41323230-5204-4504-8d34-2f4db9e16326" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20f0e758-ee64-4930-b6d2-f95ddecf9bd9", "6205e2c0-704c-481b-b44b-a42a50a325b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f0e758-ee64-4930-b6d2-f95ddecf9bd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658006f0-6da4-43db-bdff-88e5c242cb1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd388a39-003c-4535-839a-e7009506ef1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06687f64-7673-4a0d-8837-55cd90e220f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41323230-5204-4504-8d34-2f4db9e16326");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6205e2c0-704c-481b-b44b-a42a50a325b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c549232-4527-4ce5-90c5-db969bbb0ae6", null, "Citizen", "CITIZEN" },
                    { "78aaaa40-7097-4027-b9c9-b492038131b2", null, "judged", "JUDGED" },
                    { "80a3acc5-66d9-4796-bbe0-089838b7ab65", null, "Admin", "ADMIN" },
                    { "b6100b13-e19c-4823-823e-cd3b561f8da4", null, "Policeman", "POLICEMAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a36d40f-a6a5-4bb4-830f-f6a0719ec155", 0, null, "8ee13a1d-d971-4a18-bafe-c6d375126b6d", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENkcDpV7z9Uy+g+m91kSHqhh2VHsSI6yBaNrRtgYi6YWFjeAT7KMR1u/D8TQzGq4VA==", null, false, "e7597c51-de4c-4b41-9a3d-6a542a4c0181", false, "admin" },
                    { "6bcde9d8-74f1-4235-9aba-41f51ecad291", 0, null, "8de2d324-1d42-456e-825b-aa0a6610bb03", "judged@gmail.com", true, null, false, null, "JUDGED@GMAIL.COM", "JUDGED", "AQAAAAIAAYagAAAAENP00zRc0n+TyZz3/kojpWDrBxQPhlFAWwF4G0/VJbuty4jN4cJ9mN7+wP2mcmuCig==", null, false, "801e5de1-05ef-4355-86df-4d0a9b394c77", false, "judged" },
                    { "6d9aa857-1fe0-4e64-94b4-cb597f5b5d25", 0, null, "fd5e108e-0339-406c-b083-b480be14b0fb", "policeman@gmail.com", true, null, false, null, "POLICEMAN@GMAIL.COM", "POLICEMAN", "AQAAAAIAAYagAAAAEOFaHNuO7uF1ryCh6w0RHqrRpI5KS/jssMkhr3hMecJnj20V8HchfKBtbAfZlha/RQ==", null, false, "ed183b29-45f3-48fd-8d1c-6be05a0ccab3", false, "policeman" },
                    { "fb714de1-c2f3-4fff-abe8-e3a5a8e1f56b", 0, null, "f96c92bb-a5b0-45f5-a44a-551bdf69e276", "citizen@gmail.com", true, null, false, null, "CITIZEN@GMAIL.COM", "CITIZEN", "AQAAAAIAAYagAAAAEAf7vWkXCLeI2JpAOdyh3NQQCS5yw5MWZnNe2MPeqEo0dSNY6h7gAKMMCV9t0x3CGg==", null, false, "00717abb-8bf5-4906-8c79-b9ee6e8f8c9e", false, "citizen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80a3acc5-66d9-4796-bbe0-089838b7ab65", "3a36d40f-a6a5-4bb4-830f-f6a0719ec155" },
                    { "78aaaa40-7097-4027-b9c9-b492038131b2", "6bcde9d8-74f1-4235-9aba-41f51ecad291" },
                    { "b6100b13-e19c-4823-823e-cd3b561f8da4", "6d9aa857-1fe0-4e64-94b4-cb597f5b5d25" },
                    { "3c549232-4527-4ce5-90c5-db969bbb0ae6", "fb714de1-c2f3-4fff-abe8-e3a5a8e1f56b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80a3acc5-66d9-4796-bbe0-089838b7ab65", "3a36d40f-a6a5-4bb4-830f-f6a0719ec155" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78aaaa40-7097-4027-b9c9-b492038131b2", "6bcde9d8-74f1-4235-9aba-41f51ecad291" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6100b13-e19c-4823-823e-cd3b561f8da4", "6d9aa857-1fe0-4e64-94b4-cb597f5b5d25" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c549232-4527-4ce5-90c5-db969bbb0ae6", "fb714de1-c2f3-4fff-abe8-e3a5a8e1f56b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c549232-4527-4ce5-90c5-db969bbb0ae6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78aaaa40-7097-4027-b9c9-b492038131b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a3acc5-66d9-4796-bbe0-089838b7ab65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6100b13-e19c-4823-823e-cd3b561f8da4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a36d40f-a6a5-4bb4-830f-f6a0719ec155");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bcde9d8-74f1-4235-9aba-41f51ecad291");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d9aa857-1fe0-4e64-94b4-cb597f5b5d25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb714de1-c2f3-4fff-abe8-e3a5a8e1f56b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20f0e758-ee64-4930-b6d2-f95ddecf9bd9", null, "SuperAdmin", "SUPERADMIN" },
                    { "658006f0-6da4-43db-bdff-88e5c242cb1b", null, "User", "USER" },
                    { "bd388a39-003c-4535-839a-e7009506ef1a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06687f64-7673-4a0d-8837-55cd90e220f2", 0, null, "31b50e21-99da-4633-bd12-e257a95288e2", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEGZ+YASLpJSRtdoYnrfDzJXRro4A/H+q7c5+ZotXQ11nl4T2SOAfXJAnRAMiZz337w==", null, false, "d29b2fa5-8747-4c4f-88dd-720c165c7699", false, "user@gmail.com" },
                    { "41323230-5204-4504-8d34-2f4db9e16326", 0, null, "f54dbea9-61dc-472c-8877-80f16d5590e4", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJfUCVMTXViWdciVthOUbtY4RYyN+i19VMskbTbsM+zrhEG4Imztw0prQi5ZCseo9Q==", null, false, "6275b346-66a2-4693-9551-23d131b1c29b", false, "admin@gmail.com" },
                    { "6205e2c0-704c-481b-b44b-a42a50a325b3", 0, null, "1c27b83c-21e2-469e-88e4-4b30f15b9d1d", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJlgWxXb5jcXUBFkHOHv4SpPmhiYZNmxaurmKVfrhVbHH6vZ3F5cUGH12siW2L/MuA==", null, false, "f0011df3-0841-4b6c-82ac-3a1f932edd5a", false, "superAdmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "658006f0-6da4-43db-bdff-88e5c242cb1b", "06687f64-7673-4a0d-8837-55cd90e220f2" },
                    { "bd388a39-003c-4535-839a-e7009506ef1a", "41323230-5204-4504-8d34-2f4db9e16326" },
                    { "20f0e758-ee64-4930-b6d2-f95ddecf9bd9", "6205e2c0-704c-481b-b44b-a42a50a325b3" }
                });
        }
    }
}
