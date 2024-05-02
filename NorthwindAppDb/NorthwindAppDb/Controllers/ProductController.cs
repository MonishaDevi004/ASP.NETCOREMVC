using Microsoft.AspNetCore.Mvc;
using NorthwindAppDb.Repository;

namespace NorthwindAppDb.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult GetProductSupplierDetails()
        {
            dynamic item = productRepository.GetProductSupplier();

            return View(item);
        }
    }
}
