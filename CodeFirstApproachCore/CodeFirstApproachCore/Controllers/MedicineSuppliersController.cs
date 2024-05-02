using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirstApproachCore.Models;

namespace CodeFirstApproachCore.Controllers
{
    public class MedicineSuppliersController : Controller
    {
        private readonly MedicineStoreContext _context;

        public MedicineSuppliersController(MedicineStoreContext context)
        {
            _context = context;
        }

        // GET: MedicineSuppliers
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicineSupplier.ToListAsync());
        }

        // GET: MedicineSuppliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineSupplier = await _context.MedicineSupplier
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (medicineSupplier == null)
            {
                return NotFound();
            }

            return View(medicineSupplier);
        }

        // GET: MedicineSuppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicineSuppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,SupplierName,ContactDetails")] MedicineSupplier medicineSupplier)
        {

           _context.Add(medicineSupplier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
           /*  if (ModelState.IsValid)
               {
                   _context.Add(medicineSupplier);
                   await _context.SaveChangesAsync();
                   return RedirectToAction(nameof(Index));
               }*/
               return View(medicineSupplier);
        }

        // GET: MedicineSuppliers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineSupplier = await _context.MedicineSupplier.FindAsync(id);
            if (medicineSupplier == null)
            {
                return NotFound();
            }
            return View(medicineSupplier);
        }

        // POST: MedicineSuppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,SupplierName,ContactDetails")] MedicineSupplier medicineSupplier)
        {
            if (id != medicineSupplier.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicineSupplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineSupplierExists(medicineSupplier.SupplierId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicineSupplier);
        }

        // GET: MedicineSuppliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineSupplier = await _context.MedicineSupplier
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (medicineSupplier == null)
            {
                return NotFound();
            }

            return View(medicineSupplier);
        }

        // POST: MedicineSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicineSupplier = await _context.MedicineSupplier.FindAsync(id);
            if (medicineSupplier != null)
            {
                _context.MedicineSupplier.Remove(medicineSupplier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineSupplierExists(int id)
        {
            return _context.MedicineSupplier.Any(e => e.SupplierId == id);
        }
    }
}
