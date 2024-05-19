using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infa.Data.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ACTIVITY");

            migrationBuilder.EnsureSchema(
                name: "AREA");

            migrationBuilder.EnsureSchema(
                name: "PERSON");

            migrationBuilder.CreateTable(
                name: "Activity",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false, comment: "Place of service"),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                name: "Country",
                schema: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    EnFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EnLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    mobnumber = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    AspNetUsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsibility",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelevantSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportation",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTransportationAreaId = table.Column<int>(type: "int", nullable: false),
                    EndTransportationAreaId = table.Column<int>(type: "int", nullable: false),
                    startDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfTransportation = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transportation_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Province",
                schema: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "AREA",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConfirmationCertificate",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsConfirmedActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConfirmationCertificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConfirmationCertificate_People_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "PERSON",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalRegistration",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ResponsibilityId = table.Column<int>(type: "int", nullable: false),
                    PersonCreatorId = table.Column<int>(type: "int", nullable: false),
                    NumberOfPatient = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalRegistration_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinalRegistration_Responsibility_ResponsibilityId",
                        column: x => x.ResponsibilityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Responsibility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreRegistration",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ResponsibilityId = table.Column<int>(type: "int", nullable: false),
                    PersonCreatorId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PersonDeletedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreRegistration_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreRegistration_Responsibility_ResponsibilityId",
                        column: x => x.ResponsibilityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Responsibility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibilityTR",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    ResponsibilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilityTR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibilityTR_Responsibility_ResponsibilityId",
                        column: x => x.ResponsibilityId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Responsibility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedPersonId = table.Column<int>(type: "int", nullable: false),
                    CrearedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedPersonId = table.Column<int>(type: "int", nullable: true),
                    TransportationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Transportation_TransportationId",
                        column: x => x.TransportationId,
                        principalSchema: "ACTIVITY",
                        principalTable: "Transportation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                schema: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zone_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "AREA",
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "PERSON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                name: "RequestTicket",
                schema: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalRegistrationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedPersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedPersonId = table.Column<int>(type: "int", nullable: false),
                    DataRequest = table.Column<DateOnly>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTicket_FinalRegistration_FinalRegistrationId",
                        column: x => x.FinalRegistrationId,
                        principalSchema: "ACTIVITY",
                        principalTable: "FinalRegistration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                schema: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "AREA",
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportationArea",
                schema: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportationArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportationArea_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "AREA",
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Area_ZoneId",
                schema: "AREA",
                table: "Area",
                column: "ZoneId");

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
                name: "IX_FinalRegistration_ActivityId",
                schema: "ACTIVITY",
                table: "FinalRegistration",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalRegistration_ResponsibilityId",
                schema: "ACTIVITY",
                table: "FinalRegistration",
                column: "ResponsibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConfirmationCertificate_PersonId",
                schema: "PERSON",
                table: "PersonConfirmationCertificate",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkill_SkillsId",
                schema: "PERSON",
                table: "PersonSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistration_ActivityId",
                schema: "ACTIVITY",
                table: "PreRegistration",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistration_ResponsibilityId",
                schema: "ACTIVITY",
                table: "PreRegistration",
                column: "ResponsibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                schema: "AREA",
                table: "Province",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTicket_FinalRegistrationId",
                schema: "ACTIVITY",
                table: "RequestTicket",
                column: "FinalRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilityTR_ResponsibilityId",
                schema: "ACTIVITY",
                table: "ResponsibilityTR",
                column: "ResponsibilityId");

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
                name: "IX_Ticket_TransportationId",
                schema: "ACTIVITY",
                table: "Ticket",
                column: "TransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_ActivityId",
                schema: "ACTIVITY",
                table: "Transportation",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportationArea_ZoneId",
                schema: "AREA",
                table: "TransportationArea",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfMedicalCertificate_PersonConfirmationCertificateId",
                schema: "PERSON",
                table: "TypeOfMedicalCertificate",
                column: "PersonConfirmationCertificateId",
                unique: true,
                filter: "[PersonConfirmationCertificateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_ProvinceId",
                schema: "AREA",
                table: "Zone",
                column: "ProvinceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area",
                schema: "AREA");

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
                name: "PreRegistration",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "RequestTicket",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "ResponsibilityTR",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "SkillTranslate",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "Ticket",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "TransportationArea",
                schema: "AREA");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FinalRegistration",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "Skill",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "Transportation",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "Zone",
                schema: "AREA");

            migrationBuilder.DropTable(
                name: "Responsibility",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "TypeOfMedicalCertificate",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "Activity",
                schema: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "Province",
                schema: "AREA");

            migrationBuilder.DropTable(
                name: "PersonConfirmationCertificate",
                schema: "PERSON");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "AREA");

            migrationBuilder.DropTable(
                name: "People",
                schema: "PERSON");
        }
    }
}
