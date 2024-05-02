namespace NorthwindAppDb.Repository
{
    public interface IProductRepository
    {
        Task<dynamic> GetProductSupplier();
    }
}
