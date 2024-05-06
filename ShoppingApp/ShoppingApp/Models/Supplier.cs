using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set;}
        public string SupplierDescription { get; set;}


    }
}
