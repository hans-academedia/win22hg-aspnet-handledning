using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories;

public class ProductRepository : Repository<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }

}
