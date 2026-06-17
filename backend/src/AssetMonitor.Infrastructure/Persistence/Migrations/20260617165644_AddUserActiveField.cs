using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetMonitor.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserActiveField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "users",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "users");
        }
    }
}
