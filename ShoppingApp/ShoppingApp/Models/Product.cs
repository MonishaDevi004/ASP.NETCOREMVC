using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Please enter the ProductName")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        //Navigation Property
        public virtual Supplier Supplier { get; set; }



    }
}
