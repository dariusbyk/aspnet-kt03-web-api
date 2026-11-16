using ProductsApi.Data;
using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public IRepository<Product> Products { get; private set; }

        public UnitOfWork(AppDbContext context, IRepository<Product> products)
        {
            this.context = context;
            Products = products;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
