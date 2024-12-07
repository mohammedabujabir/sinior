using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class addinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Camera_id",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4429fbab-c34e-4ce5-a700-cac5e120e747", null, "Citizen", "CITIZEN" },
                    { "468d2c78-4fc3-4eb9-81f3-a017bc1643ed", null, "Policeman", "POLICEMAN" },
                    { "73ffa197-f32d-4ad7-9a95-94278ae5b32c", null, "judged", "JUDGED" },
                    { "ddb04d6a-bc27-40c7-a54e-ec7bd06fb1f9", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Camera_id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15778ee4-44cd-4f4c-8240-87722b6a34fb", 0, null, null, "5e42098b-7daa-4812-834a-6ae1bea4eca8", "citizen@gmail.com", true, null, false, null, "CITIZEN@GMAIL.COM", "CITIZEN", "AQAAAAIAAYagAAAAEDqFarNPizu24drjvY1j2klBlG78swqgSnKgT1UmMNvwiBJm/rNlI7Y0a5yhCG2dZg==", null, false, "e336f726-cdee-4f7e-8c1a-1c18ae909c34", false, "citizen" },
                    { "3f2f3354-b688-422f-be2a-3d4df03a4241", 0, null, null, "d8c60cb0-2359-4f7f-ae05-9c0e7377d02c", "judged@gmail.com", true, null, false, null, "JUDGED@GMAIL.COM", "JUDGED", "AQAAAAIAAYagAAAAED/3SjiqUvZdoMDHkJdpsLT4wbDE9U3/8eeOJwQm4pgFOeZhB3VwsSbXYePI5ngNlA==", null, false, "4e5017cf-7e8d-4ea1-91d4-83918f0871d2", false, "judged" },
                    { "8d7316a8-9f1f-4fc3-ad53-07645c109f29", 0, null, null, "6157d681-0058-4cfb-907b-957f589a66f5", "policeman@gmail.com", true, null, false, null, "POLICEMAN@GMAIL.COM", "POLICEMAN", "AQAAAAIAAYagAAAAEMQG2F/yzjH/wYfBany7nKMZakeHu6g4jYbjxze5rH/bgnRslrAMFZWi4eb3sJr5Ng==", null, false, "a9d41f3d-a2f1-43f7-9b5d-193e0b5bce9f", false, "policeman" },
                    { "f99cd1b4-10d7-43ec-9594-3e61b3025e4d", 0, null, null, "53acbaa2-e1c7-4a5a-a9ab-2def4142f07a", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGTQFY5/x3VMFBEjf4RE0unKKIXvfNcUK3MuN46Wb4AsN1+rVy1oTQc3AfI9ZnWd3A==", null, false, "7b471cd9-ebfb-4a46-89fa-b674f387aa73", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4429fbab-c34e-4ce5-a700-cac5e120e747", "15778ee4-44cd-4f4c-8240-87722b6a34fb" },
                    { "4429fbab-c34e-4ce5-a700-cac5e120e747", "32aaef0d-10b1-4576-a9a3-e0a5986f2bc5" },
                    { "73ffa197-f32d-4ad7-9a95-94278ae5b32c", "3f2f3354-b688-422f-be2a-3d4df03a4241" },
                    { "468d2c78-4fc3-4eb9-81f3-a017bc1643ed", "8d7316a8-9f1f-4fc3-ad53-07645c109f29" },
                    { "ddb04d6a-bc27-40c7-a54e-ec7bd06fb1f9", "f99cd1b4-10d7-43ec-9594-3e61b3025e4d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4429fbab-c34e-4ce5-a700-cac5e120e747", "15778ee4-44cd-4f4c-8240-87722b6a34fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4429fbab-c34e-4ce5-a700-cac5e120e747", "32aaef0d-10b1-4576-a9a3-e0a5986f2bc5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73ffa197-f32d-4ad7-9a95-94278ae5b32c", "3f2f3354-b688-422f-be2a-3d4df03a4241" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "468d2c78-4fc3-4eb9-81f3-a017bc1643ed", "8d7316a8-9f1f-4fc3-ad53-07645c109f29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddb04d6a-bc27-40c7-a54e-ec7bd06fb1f9", "f99cd1b4-10d7-43ec-9594-3e61b3025e4d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4429fbab-c34e-4ce5-a700-cac5e120e747");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "468d2c78-4fc3-4eb9-81f3-a017bc1643ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ffa197-f32d-4ad7-9a95-94278ae5b32c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb04d6a-bc27-40c7-a54e-ec7bd06fb1f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15778ee4-44cd-4f4c-8240-87722b6a34fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f2f3354-b688-422f-be2a-3d4df03a4241");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d7316a8-9f1f-4fc3-ad53-07645c109f29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99cd1b4-10d7-43ec-9594-3e61b3025e4d");

            migrationBuilder.DropColumn(
                name: "Camera_id",
                table: "AspNetUsers");

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
    }
}
