using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class updaterelationbetweencitizenandCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_CitizenId",
                table: "Cars");

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
                name: "IX_Cars_CitizenId",
                table: "Cars",
                column: "CitizenId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Citizens_CitizenId1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CitizenId",
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
                name: "IX_Cars_CitizenId",
                table: "Cars",
                column: "CitizenId",
                unique: true);
        }
    }
}
