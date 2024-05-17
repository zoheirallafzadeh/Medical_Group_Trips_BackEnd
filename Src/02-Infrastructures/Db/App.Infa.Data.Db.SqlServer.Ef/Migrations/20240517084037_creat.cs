using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infa.Data.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class creat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PERSON");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonConfirmationCertificate",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConfirmationCertificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EnFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EnLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    mobnumber = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    AspNetUsersId = table.Column<int>(type: "int", nullable: true),
                    PersonConfirmationCertificateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_PersonConfirmationCertificate_PersonConfirmationCertificateId",
                        column: x => x.PersonConfirmationCertificateId,
                        principalSchema: "PERSON",
                        principalTable: "PersonConfirmationCertificate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeOfMedicalCertificate",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonConfirmationCertificateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfMedicalCertificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeOfMedicalCertificate_PersonConfirmationCertificate_PersonConfirmationCertificateId",
                        column: x => x.PersonConfirmationCertificateId,
                        principalSchema: "PERSON",
                        principalTable: "PersonConfirmationCertificate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonConfirmationCertificateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_People_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "PERSON",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_PersonConfirmationCertificate_PersonConfirmationCertificateId",
                        column: x => x.PersonConfirmationCertificateId,
                        principalSchema: "PERSON",
                        principalTable: "PersonConfirmationCertificate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    TypeOfMedicalCertificateId = table.Column<int>(type: "int", nullable: true),
                    PersonConfirmationCertificateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_PersonConfirmationCertificate_PersonConfirmationCertificateId",
                        column: x => x.PersonConfirmationCertificateId,
                        principalSchema: "PERSON",
                        principalTable: "PersonConfirmationCertificate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Skill_TypeOfMedicalCertificate_TypeOfMedicalCertificateId",
                        column: x => x.TypeOfMedicalCertificateId,
                        principalSchema: "PERSON",
                        principalTable: "TypeOfMedicalCertificate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonSkill",
                schema: "PERSON",
                columns: table => new
                {
                    PersonsId = table.Column<int>(type: "int", nullable: false),
                    SkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSkill", x => new { x.PersonsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_PersonSkill_People_PersonsId",
                        column: x => x.PersonsId,
                        principalSchema: "PERSON",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonSkill_Skill_SkillsId",
                        column: x => x.SkillsId,
                        principalSchema: "PERSON",
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillTranslate",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNeedConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTranslate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillTranslate_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "PERSON",
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonConfirmationCertificateId",
                schema: "PERSON",
                table: "Document",
                column: "PersonConfirmationCertificateId",
                unique: true,
                filter: "[PersonConfirmationCertificateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonId",
                schema: "PERSON",
                table: "Document",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonConfirmationCertificateId",
                schema: "PERSON",
                table: "People",
                column: "PersonConfirmationCertificateId",
                unique: true,
                filter: "[PersonConfirmationCertificateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkill_SkillsId",
                schema: "PERSON",
                table: "PersonSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_PersonConfirmationCertificateId",
                schema: "PERSON",
                table: "Skill",
                column: "PersonConfirmationCertificateId",
                unique: true,
                filter: "[PersonConfirmationCertificateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_TypeOfMedicalCertificateId",
                schema: "PERSON",
                table: "Skill",
                column: "TypeOfMedicalCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTranslate_SkillId",
                schema: "PERSON",
                table: "SkillTranslate",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfMedicalCertificate_PersonConfirmationCertificateId",
                schema: "PERSON",
                table: "TypeOfMedicalCertificate",
                column: "PersonConfirmationCertificateId",
                unique: true,
                filter: "[PersonConfirmationCertificateId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Document",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "PersonSkill",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "SkillTranslate",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "People",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "Skill",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "TypeOfMedicalCertificate",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "PersonConfirmationCertificate",
                schema: "PERSON");
        }
    }
}
