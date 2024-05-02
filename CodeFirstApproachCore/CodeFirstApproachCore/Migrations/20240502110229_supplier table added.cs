using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachCore.Migrations
{
    /// <inheritdoc />
    public partial class suppliertableadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicineSupplierSupplierId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MedicineSupplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineSupplier", x => x.SupplierId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_MedicineSupplierSupplierId",
                table: "Medicines",
                column: "MedicineSupplierSupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines",
                column: "MedicineSupplierSupplierId",
                principalTable: "MedicineSupplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "MedicineSupplier");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_MedicineSupplierSupplierId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "MedicineSupplierSupplierId",
                table: "Medicines");
        }
    }
}
