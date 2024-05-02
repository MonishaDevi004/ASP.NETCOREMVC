using Microsoft.AspNetCore.Mvc;
using NorthwindAppDb.Repository;
using NorthwindAppDb.ViewModel;

namespace NorthwindAppDb.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        //View Model
        public IActionResult GetProductSupplierDetails()
        {
            dynamic productsupplieritem = productRepository.GetProductSupplier();

            List<ProductSupplierVM> vmlistobj = new List<ProductSupplierVM>();

            foreach(var item in productsupplieritem)
            {
                ProductSupplierVM vmobj = new ProductSupplierVM();
                vmobj.ProductId = item.ProductId;
                vmobj.ProductName = item.ProductName;
                vmobj.UnitPrice = item.UnitPrice;
                vmobj.CompanyName = item.CompanyName;
                vmlistobj.Add(vmobj);
            }

            return View(vmlistobj);
        }

        //Call the procedure with out parameter

        public IActionResult CallProcedurewithoutparameter()
        {
            return View(productRepository.GetMostExpensiveProducts());

        }


    }
}
