using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachCore.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeysupplieridadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Medicines");
        }
    }
}
