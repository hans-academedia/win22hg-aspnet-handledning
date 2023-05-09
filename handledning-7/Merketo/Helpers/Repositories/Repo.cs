using Merketo.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Merketo.Helpers.Repositories;

public interface IRepo<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity TEntity);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression);
    Task<TEntity> UpdateAsync(TEntity TEntity);
    Task RemoveAsync(TEntity TEntity);
}


public abstract class Repo<TEntity> : IRepo<TEntity> where TEntity : class
{
    #region constructors and private fields

    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }

    #endregion

    public virtual async Task<TEntity> AddAsync(TEntity TEntity)
    {
        await _context.Set<TEntity>().AddAsync(TEntity);
        await _context.SaveChangesAsync();
        return TEntity;
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        var TEntity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        return TEntity!;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _context.Set<TEntity>().Where(expression).ToListAsync();
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity TEntity)
    {
        _context.Set<TEntity>().Update(TEntity);
        await _context.SaveChangesAsync();
        return TEntity;
    }

    public virtual async Task RemoveAsync(TEntity TEntity)
    {
        _context.Set<TEntity>().Remove(TEntity);
        await _context.SaveChangesAsync();
    }
}
