using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstwithRelation.Models
{
    public class Product1
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [ForeignKey("Suppliers")]
        public int SupplierId { get; set; }
        public virtual Supplier Suppliers { get; set; }
    }
}
