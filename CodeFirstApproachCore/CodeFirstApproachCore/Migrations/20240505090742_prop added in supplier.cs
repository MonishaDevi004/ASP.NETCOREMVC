using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachCore.Migrations
{
    /// <inheritdoc />
    public partial class propaddedinsupplier : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Medicines_MedicineSupplierSupplierId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "MedicineSupplierSupplierId",
                table: "Medicines");
        }
    }
}
