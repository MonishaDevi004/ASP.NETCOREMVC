using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirstwithRelation.Models;

namespace CodeFirstwithRelation.Controllers
{
    public class Product1Controller : Controller
    {
        private readonly CartContext _context;

        public Product1Controller(CartContext context)
        {
            _context = context;
        }

        // GET: Product1
        public async Task<IActionResult> Index()
        {
            var cartContext = _context.Products.Include(p => p.Suppliers);
            return View(await cartContext.ToListAsync());
        }

        // GET: Product1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product1 = await _context.Products
                .Include(p => p.Suppliers)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product1 == null)
            {
                return NotFound();
            }

            return View(product1);
        }

        // GET: Product1/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId");
            return View();
        }

        // POST: Product1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,SupplierId")] Product1 product1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", product1.SupplierId);
            return View(product1);
        }

        // GET: Product1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product1 = await _context.Products.FindAsync(id);
            if (product1 == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", product1.SupplierId);
            return View(product1);
        }

        // POST: Product1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,SupplierId")] Product1 product1)
        {
            if (id != product1.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product1Exists(product1.ProductId))
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
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", product1.SupplierId);
            return View(product1);
        }

        // GET: Product1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product1 = await _context.Products
                .Include(p => p.Suppliers)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product1 == null)
            {
                return NotFound();
            }

            return View(product1);
        }

        // POST: Product1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product1 = await _context.Products.FindAsync(id);
            if (product1 != null)
            {
                _context.Products.Remove(product1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product1Exists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
