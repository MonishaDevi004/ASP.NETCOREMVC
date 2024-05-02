using Microsoft.EntityFrameworkCore;
using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public class OrderService :IOrdersRepository
    {
        private readonly NorthwindContext context;

        public OrderService(NorthwindContext context)
        {
            this.context = context;
        }
       public List<CustOrdersOrders> GetCustOrdersOrders(string Customerid)
        {
            // List<CustOrdersOrders> orders = context.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders] @p0", new[] {Customerid}).ToList();

            List<CustOrdersOrders> orders = context.CustOrdersOrders.FromSqlInterpolated($"CustOrdersOrders @Customerid = {Customerid}").ToList();  

            return orders;
        }
    }
}
