using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class realtionbetwwencitizenandcar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    CitizenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Camera_id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.CitizenId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Citizens_CitizenId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CitizenId",
                table: "Cars",
                column: "CitizenId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Citizens");

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
    }
}
