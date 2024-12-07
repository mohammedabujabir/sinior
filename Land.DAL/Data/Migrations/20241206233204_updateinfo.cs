using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traffic_Violations");

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

            migrationBuilder.CreateTable(
                name: "Court",
                columns: table => new
                {
                    CourtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Court", x => x.CourtId);
                });

            migrationBuilder.CreateTable(
                name: "Judge",
                columns: table => new
                {
                    JudgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judge", x => x.JudgeId);
                });

            migrationBuilder.CreateTable(
                name: "Policeman",
                columns: table => new
                {
                    PolicemanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Badge_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policeman", x => x.PolicemanId);
                });

            migrationBuilder.CreateTable(
                name: "TrafficViolation",
                columns: table => new
                {
                    TrafficViolationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reported_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Car_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenId = table.Column<int>(type: "int", nullable: false),
                    DecisionId = table.Column<int>(type: "int", nullable: true),
                    CourtDecisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficViolation", x => x.TrafficViolationId);
                    table.ForeignKey(
                        name: "FK_TrafficViolation_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicemanDecision",
                columns: table => new
                {
                    PolicemanDecisionId = table.Column<int>(type: "int", nullable: false),
                    Violationid = table.Column<int>(type: "int", nullable: false),
                    Policemanid = table.Column<int>(type: "int", nullable: false),
                    DecisionNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferredToCourt = table.Column<bool>(type: "bit", nullable: false),
                    CourtDecisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicemanDecision", x => x.PolicemanDecisionId);
                    table.ForeignKey(
                        name: "FK_PolicemanDecision_Policeman_PolicemanDecisionId",
                        column: x => x.PolicemanDecisionId,
                        principalTable: "Policeman",
                        principalColumn: "PolicemanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicemanDecision_TrafficViolation_Violationid",
                        column: x => x.Violationid,
                        principalTable: "TrafficViolation",
                        principalColumn: "TrafficViolationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourtDecisions",
                columns: table => new
                {
                    CourtDecisionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Violationid = table.Column<int>(type: "int", nullable: false),
                    Courtid = table.Column<int>(type: "int", nullable: false),
                    Verdict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Penalty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoliceDecisionId = table.Column<int>(type: "int", nullable: true),
                    JudgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtDecisions", x => x.CourtDecisionsId);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_Court_Courtid",
                        column: x => x.Courtid,
                        principalTable: "Court",
                        principalColumn: "CourtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_Judge_JudgeId",
                        column: x => x.JudgeId,
                        principalTable: "Judge",
                        principalColumn: "JudgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_PolicemanDecision_PoliceDecisionId",
                        column: x => x.PoliceDecisionId,
                        principalTable: "PolicemanDecision",
                        principalColumn: "PolicemanDecisionId");
                    table.ForeignKey(
                        name: "FK_CourtDecisions_TrafficViolation_Violationid",
                        column: x => x.Violationid,
                        principalTable: "TrafficViolation",
                        principalColumn: "TrafficViolationId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_Courtid",
                table: "CourtDecisions",
                column: "Courtid");

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_JudgeId",
                table: "CourtDecisions",
                column: "JudgeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_PoliceDecisionId",
                table: "CourtDecisions",
                column: "PoliceDecisionId",
                unique: true,
                filter: "[PoliceDecisionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_Violationid",
                table: "CourtDecisions",
                column: "Violationid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PolicemanDecision_Violationid",
                table: "PolicemanDecision",
                column: "Violationid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrafficViolation_CitizenId",
                table: "TrafficViolation",
                column: "CitizenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourtDecisions");

            migrationBuilder.DropTable(
                name: "Court");

            migrationBuilder.DropTable(
                name: "Judge");

            migrationBuilder.DropTable(
                name: "PolicemanDecision");

            migrationBuilder.DropTable(
                name: "Policeman");

            migrationBuilder.DropTable(
                name: "TrafficViolation");

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

            migrationBuilder.CreateTable(
                name: "Traffic_Violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenId = table.Column<int>(type: "int", nullable: false),
                    Car_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reported_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video_Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Traffic_Violations_CitizenId",
                table: "Traffic_Violations",
                column: "CitizenId");
        }
    }
}
