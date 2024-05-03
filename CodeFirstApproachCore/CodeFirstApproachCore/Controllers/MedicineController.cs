using CodeFirstApproachCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CodeFirstApproachCore.Controllers
{
    public class MedicineController : Controller
    {
        private readonly MedicineStoreContext context;
        public MedicineController(MedicineStoreContext context) {
        
            this.context = context;
        }

        //Get particular Medicine
        public IActionResult Details(int id)
        {
            Medicine medicine = null;
            if (id != null) {

             medicine =  context.Medicines.FirstOrDefault(x => x.MedicineId  == id);

            
            }
            return View(medicine);
        }

        //Add Medicine


      /*  public IActionResult Create()
        {
            var suppliers = _context.Suppliers.ToList(); // Assuming _context is your DbContext
            ViewData["SupplierList"] = new SelectList(suppliers, "SupplierId", "Name"); // Assuming Name is the property you want to display
            return View();
        }*/


        [HttpGet]
        public IActionResult Create() {

           

            var suppliers = context.MedicineSupplier.ToList(); // Assuming db is your DbContext

            // ViewBag.SupplierList = new SelectList(suppliers, "SupplierId", "Supplier id"); // Assuming Name is the property you want to display
            var data = from supplier in context.MedicineSupplier
                       select new { supplier.SupplierId };
            
            List<SelectListItem> list = new List<SelectListItem>();
            foreach(var item in data)
            {
                list.Add(new SelectListItem { Text = item.ToString() });
            }
            
            ViewBag.Message = list;
            return View(); 
           
        }

        [HttpPost]
        public IActionResult Create(Medicine medicine)
        {
            context.Medicines.Add(medicine);
            context.SaveChanges();
            return View();

        }



    }
}
