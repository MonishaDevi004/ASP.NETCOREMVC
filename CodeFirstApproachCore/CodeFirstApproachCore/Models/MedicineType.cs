using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachCore.Models
{
    public class MedicineSupplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public string ContactDetails { get; set;}

     /*   [JsonIgnore]
        public virtual ICollection<Medicine> Medicines { get; set; }*/
    }
}
