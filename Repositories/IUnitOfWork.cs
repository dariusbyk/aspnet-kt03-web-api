using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        Task SaveAsync();
    }
}
