using Merketo.Contexts;
using Merketo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Merketo.Helpers.Repositories;

public class ProductEntityRepo : Repo<ProductEntity>
{
    private readonly DataContext _context;

    public ProductEntityRepo(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        var items = await _context.Products
            .Include(x => x.Tags).ThenInclude(x => x.Tag)
            .ToListAsync();

        return items;
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync(Expression<Func<ProductEntity, bool>> expression)
    {
        var items = await _context.Products
            .Include(x => x.Tags).ThenInclude(x => x.Tag)
            .Where(expression)
            .ToListAsync();

        return items;
    }

    public override async Task<ProductEntity> GetAsync(Expression<Func<ProductEntity, bool>> expression)
    {
        var item = await _context.Products
            .Include(x => x.Tags).ThenInclude(x => x.Tag)
            .FirstOrDefaultAsync(expression);

        return item!;
    }
}
