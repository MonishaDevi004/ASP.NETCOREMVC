using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingApp.Models;
using ShoppingApp.Repository;

namespace ShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            var supplier =(IEnumerable<Supplier>) (await _productRepository.GetAllSupplier());
            ViewData["SupplierId"] = new SelectList(supplier,"SupplierId","SupplierId");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                _productRepository.AddProduct(product);
                return View();

            }
            return View();
        }
    }
}
