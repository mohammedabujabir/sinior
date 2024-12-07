using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class trafficviolations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd202d39-b7cf-45a9-b4bb-4ee807555dd8", "0bd8b697-4adc-4079-99d1-c6d691ea1248" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98a64f3c-c4be-4b1a-9e58-feecca159e72", "3e5c20b9-947b-4da6-b339-8a4b7c89e706" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77bbeacc-10b7-434a-9999-9349618cf7e0", "4cb85933-8dd9-4a56-9e8d-2eeb6dd947ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77bbeacc-10b7-434a-9999-9349618cf7e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98a64f3c-c4be-4b1a-9e58-feecca159e72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd202d39-b7cf-45a9-b4bb-4ee807555dd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bd8b697-4adc-4079-99d1-c6d691ea1248");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e5c20b9-947b-4da6-b339-8a4b7c89e706");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cb85933-8dd9-4a56-9e8d-2eeb6dd947ae");

            migrationBuilder.CreateTable(
                name: "Traffic_Violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reported_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Car_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traffic_Violations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traffic_Violations_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03363c4d-61cf-402a-bf5b-61e05cdd7569", null, "User", "USER" },
                    { "316b9733-0842-4a6e-bb32-5b6aee7967d3", null, "Admin", "ADMIN" },
                    { "de52c74f-01b2-4b17-813b-62371552fa17", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1964f5a9-cccd-46a2-adcf-f39950223922", 0, null, "ccfb76bb-c705-45ae-bb9e-0683f0479ca7", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEGFYiP+yjtk0KFuKmLZLKlwjyUKstfWLbKyvqnAFIdr2iwmiAeSLOK97VmoeeUr9bg==", null, false, "5f3307b8-dbe6-461c-a76d-919fd4ff53ef", false, "superAdmin@gmail.com" },
                    { "a450ad58-1638-4cfd-a476-458569238715", 0, null, "0ab43611-1214-4637-9eee-b3ecfed3a20f", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPdALtmw2o/LKNHRpGQAeGkRIkYkIqXLN7Mq98TVHNu3pyrbzMVjZ4C6UDOpUcyU+A==", null, false, "755a14ea-0aac-491d-94cf-d36aae1d32a2", false, "admin@gmail.com" },
                    { "cc5be3a1-c281-41c0-8e72-f6c8d072feac", 0, null, "e4256af9-7edb-4cb6-a06a-51f064464936", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEEB0G45JS8PihQilbQx48DdR20CWRq96frH+Y96r13wyfGoCnMeHzY59WZToE9pMpg==", null, false, "33092af2-3383-4e7b-b407-2a61b9007eea", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de52c74f-01b2-4b17-813b-62371552fa17", "1964f5a9-cccd-46a2-adcf-f39950223922" },
                    { "316b9733-0842-4a6e-bb32-5b6aee7967d3", "a450ad58-1638-4cfd-a476-458569238715" },
                    { "03363c4d-61cf-402a-bf5b-61e05cdd7569", "cc5be3a1-c281-41c0-8e72-f6c8d072feac" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Traffic_Violations_CitizenId",
                table: "Traffic_Violations",
                column: "CitizenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traffic_Violations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de52c74f-01b2-4b17-813b-62371552fa17", "1964f5a9-cccd-46a2-adcf-f39950223922" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "316b9733-0842-4a6e-bb32-5b6aee7967d3", "a450ad58-1638-4cfd-a476-458569238715" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03363c4d-61cf-402a-bf5b-61e05cdd7569", "cc5be3a1-c281-41c0-8e72-f6c8d072feac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03363c4d-61cf-402a-bf5b-61e05cdd7569");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "316b9733-0842-4a6e-bb32-5b6aee7967d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de52c74f-01b2-4b17-813b-62371552fa17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1964f5a9-cccd-46a2-adcf-f39950223922");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a450ad58-1638-4cfd-a476-458569238715");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc5be3a1-c281-41c0-8e72-f6c8d072feac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "77bbeacc-10b7-434a-9999-9349618cf7e0", null, "SuperAdmin", "SUPERADMIN" },
                    { "98a64f3c-c4be-4b1a-9e58-feecca159e72", null, "Admin", "ADMIN" },
                    { "dd202d39-b7cf-45a9-b4bb-4ee807555dd8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bd8b697-4adc-4079-99d1-c6d691ea1248", 0, null, "24bf9222-b48c-4939-929c-5628c426ce04", "user@gmail.com", true, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEAM2X38AFYpmPp0C0yBIOW4HT2pmffVDDRjESbZAVw4EKpr2w20chNWnQxgWg0YPsg==", null, false, "c9711e81-0d10-4392-b1c5-e19051089bd3", false, "user@gmail.com" },
                    { "3e5c20b9-947b-4da6-b339-8a4b7c89e706", 0, null, "bedc53f3-78e7-4c66-b561-a908103365f7", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEp8CSYigWFdaoHlKgzT9pfQwBJk8hFvIVNFr4nvHYhGMjF062NhOrUFJS1jMDTydg==", null, false, "f453e712-3884-44ee-85b2-4e8845197058", false, "admin@gmail.com" },
                    { "4cb85933-8dd9-4a56-9e8d-2eeb6dd947ae", 0, null, "832c1319-de66-4d8a-b1a5-dbfe6886c7c9", "superAdmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJKu9H4Hi2YDaGqsR31QQjXxUi5ekduusBsnEdDK4yNKh2Ti02yH954VSQvlanHGHQ==", null, false, "207a50b6-82bd-476a-9975-53d55d3a2577", false, "superAdmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dd202d39-b7cf-45a9-b4bb-4ee807555dd8", "0bd8b697-4adc-4079-99d1-c6d691ea1248" },
                    { "98a64f3c-c4be-4b1a-9e58-feecca159e72", "3e5c20b9-947b-4da6-b339-8a4b7c89e706" },
                    { "77bbeacc-10b7-434a-9999-9349618cf7e0", "4cb85933-8dd9-4a56-9e8d-2eeb6dd947ae" }
                });
        }
    }
}
