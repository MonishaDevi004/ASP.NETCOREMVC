using System.ComponentModel.DataAnnotations;

namespace NorthwindAppDb.Models
{
    public class Ten_Most_Expensive_Products
    {
        [Key]
        public string TenMostExpensiveProducts { get; set; }
        public Nullable<decimal> UnitPrice { get; set; } 
    }
}
