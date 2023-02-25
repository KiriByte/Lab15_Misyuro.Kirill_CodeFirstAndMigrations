using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoomName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Room");
        }
    }
}
