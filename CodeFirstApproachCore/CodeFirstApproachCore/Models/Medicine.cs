using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachCore.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineDescription { get; set; }

        public decimal MedicinePrice { get; set; }

        public int Quantity { get;set; }
        

        public virtual MedicineSupplier MedicineSupplier { get; set; }


    }
}
