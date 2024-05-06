using CodeFirstwithRelation.Models;
using CodeFirstwithRelation.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstwithRelation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            var supplier =  (IEnumerable<Supplier>) (await _repository.GetAllSupplier()) ;
            ViewData["SupplierId"] = new SelectList(supplier, "SupplierId", "SupplierId");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product1 product)
        {
            _repository.AddProduct(product);
            return View();
        }
    }
}
