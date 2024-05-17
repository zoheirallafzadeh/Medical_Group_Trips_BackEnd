using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infa.Data.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmedActive",
                schema: "PERSON",
                table: "PersonConfirmationCertificate",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmedActive",
                schema: "PERSON",
                table: "PersonConfirmationCertificate");
        }
    }
}
