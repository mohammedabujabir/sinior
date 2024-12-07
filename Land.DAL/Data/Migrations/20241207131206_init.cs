using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a1ff46f-59db-4df0-8abf-69f90ddbb0b7", null, "Policeman", "POLICEMAN" },
                    { "5d98a14e-10ca-45d6-9e47-18e49a131790", null, "Citizen", "CITIZEN" },
                    { "cf9f0790-9498-4aa2-be79-72f53860ea69", null, "Admin", "ADMIN" },
                    { "f71aa82b-27c9-47ad-88cf-bcf1dc3c3ec1", null, "judged", "JUDGED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Camera_id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6230ed47-5fd6-467c-b3ac-8ddd795ff89f", 0, null, null, "2d5456d9-fa14-4c0b-84f4-5ed2d2666ced", "citizen@gmail.com", true, null, false, null, "CITIZEN@GMAIL.COM", "CITIZEN", "AQAAAAIAAYagAAAAEH3TGa8T9Q1p7KICf/0FhI0I+3YApNwZFVoRz/cjK5qRUUo/bGlUFzZHc7WvJZcr4Q==", null, false, "f1c6a436-530a-478b-81e0-41cca85b87e7", false, "citizen" },
                    { "624d139e-75ba-4330-9ee0-339e3e06332a", 0, null, null, "75827f70-1f93-45df-a82a-0eb11795ba26", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEDnftB/sD9z5wAjET1wQRYXYAg+rDqj97Nau9XiqbYS2EtRDqvMVL9I1Ac2ZfMth9A==", null, false, "28c1d05e-e3fa-4687-b997-0ca328980beb", false, "admin" },
                    { "daac9f27-2781-42b2-b01d-905edc48eb2f", 0, null, null, "be4ac1b8-0db1-4318-a141-987b4557cb53", "judged@gmail.com", true, null, false, null, "JUDGED@GMAIL.COM", "JUDGED", "AQAAAAIAAYagAAAAEKCUvFVxSwMj81ETa4hEhrMxQWg3t7RAUmYhU1/U8IwJM4Ircq2WRmmiGMpC1Uexhg==", null, false, "593a7bc6-4b1c-45fe-8dc5-d3a2ebd3563d", false, "judged" },
                    { "e9751544-fb03-4795-ada9-caa323ee788d", 0, null, null, "a37d68b4-384d-4921-80a1-752bb0c62303", "policeman@gmail.com", true, null, false, null, "POLICEMAN@GMAIL.COM", "POLICEMAN", "AQAAAAIAAYagAAAAEM80W0KY3uyX+SgvZAh2JMnru8LSeKjmeoCtDwUuXoCZ86cH1Ba+/AgQkTEQ3EmhJg==", null, false, "8aedc6f2-a8d1-4227-8a7d-3a58db55308e", false, "policeman" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d98a14e-10ca-45d6-9e47-18e49a131790", "6230ed47-5fd6-467c-b3ac-8ddd795ff89f" },
                    { "cf9f0790-9498-4aa2-be79-72f53860ea69", "624d139e-75ba-4330-9ee0-339e3e06332a" },
                    { "f71aa82b-27c9-47ad-88cf-bcf1dc3c3ec1", "daac9f27-2781-42b2-b01d-905edc48eb2f" },
                    { "1a1ff46f-59db-4df0-8abf-69f90ddbb0b7", "e9751544-fb03-4795-ada9-caa323ee788d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d98a14e-10ca-45d6-9e47-18e49a131790", "6230ed47-5fd6-467c-b3ac-8ddd795ff89f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf9f0790-9498-4aa2-be79-72f53860ea69", "624d139e-75ba-4330-9ee0-339e3e06332a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f71aa82b-27c9-47ad-88cf-bcf1dc3c3ec1", "daac9f27-2781-42b2-b01d-905edc48eb2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a1ff46f-59db-4df0-8abf-69f90ddbb0b7", "e9751544-fb03-4795-ada9-caa323ee788d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a1ff46f-59db-4df0-8abf-69f90ddbb0b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d98a14e-10ca-45d6-9e47-18e49a131790");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf9f0790-9498-4aa2-be79-72f53860ea69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f71aa82b-27c9-47ad-88cf-bcf1dc3c3ec1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6230ed47-5fd6-467c-b3ac-8ddd795ff89f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "624d139e-75ba-4330-9ee0-339e3e06332a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daac9f27-2781-42b2-b01d-905edc48eb2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9751544-fb03-4795-ada9-caa323ee788d");

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
    }
}
