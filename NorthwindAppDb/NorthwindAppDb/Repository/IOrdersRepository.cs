using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public interface IOrdersRepository
    {
        List<CustOrdersOrders> GetCustOrdersOrders(string Customerid);
    }
}
