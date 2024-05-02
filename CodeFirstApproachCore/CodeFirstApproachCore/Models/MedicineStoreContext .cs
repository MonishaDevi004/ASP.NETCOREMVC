using Microsoft.EntityFrameworkCore;
using CodeFirstApproachCore.Models;

namespace CodeFirstApproachCore.Models
{
    public class MedicineStoreContext :DbContext
    {
        public MedicineStoreContext(DbContextOptions<MedicineStoreContext> options) :base(options) { }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<CodeFirstApproachCore.Models.MedicineSupplier> MedicineSupplier { get; set; } = default!;
    }
}
