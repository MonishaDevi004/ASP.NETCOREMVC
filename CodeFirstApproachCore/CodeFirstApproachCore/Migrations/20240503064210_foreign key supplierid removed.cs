using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachCore.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeysupplieridremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineSupplierSupplierId",
                table: "Medicines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines",
                column: "MedicineSupplierSupplierId",
                principalTable: "MedicineSupplier",
                principalColumn: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineSupplierSupplierId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_MedicineSupplier_MedicineSupplierSupplierId",
                table: "Medicines",
                column: "MedicineSupplierSupplierId",
                principalTable: "MedicineSupplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
