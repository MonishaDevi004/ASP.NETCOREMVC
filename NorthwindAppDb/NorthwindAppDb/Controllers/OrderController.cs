using Microsoft.AspNetCore.Mvc;
using NorthwindAppDb.Repository;

namespace NorthwindAppDb.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrdersRepository ordersRepository;
        public OrderController(IOrdersRepository ordersRepository) {
        
            this.ordersRepository = ordersRepository;
        }

        public IActionResult CallProcedurewithParameter()
        {
            

            return View(ordersRepository.GetCustOrdersOrders("VINET"));
        }
    }
}
