using System.ComponentModel.DataAnnotations;

namespace NorthwindAppDb.ViewModel
{
    public class ProductSupplierVM
    {
        //Product

        [Key]
        public int ProductId { get; set; }
        //Product
        public string ProductName { get; set; } = null!;
        //Product
        public decimal? UnitPrice { get; set; }
        //Supplier
        public string CompanyName { get; set; } = null!;

    }
}
