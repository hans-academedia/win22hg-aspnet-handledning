using Microsoft.EntityFrameworkCore;
using Repositories.Contexts;
using Repositories.Models.Entities;

namespace Repositories.Repos;

public class ShowcaseRepository
{
    private readonly DataContext _context;

    public ShowcaseRepository(DataContext context)
    {
        _context = context;
    }




    public async Task CreateAsync(ShowcaseEntity showcaseEntity)
    {
        _context.Add(showcaseEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<ShowcaseEntity> GetAsync(int id)
    {
        var _showcaseEntity = await _context.Showcases.FirstOrDefaultAsync(x => x.Id == id);
        return _showcaseEntity!;
    }

    public async Task<IEnumerable<ShowcaseEntity>> GetAllAsync()
    {
        return await _context.Showcases.ToListAsync();
    }

    public async Task UpdateAsync(ShowcaseEntity showcaseEntity)
    {
        var _showcaseEntity = await _context.Showcases.FirstOrDefaultAsync(x => x.Id == showcaseEntity.Id);
        if (_showcaseEntity != null)
        {
            _showcaseEntity.Title = showcaseEntity.Title;
            _showcaseEntity.Ingress = showcaseEntity.Ingress;
            _showcaseEntity.ImageUrl = showcaseEntity.ImageUrl;
            _showcaseEntity.LinkText = showcaseEntity.LinkText;
            _showcaseEntity.LinkUrl = showcaseEntity.LinkUrl;   

            _context.Update(_showcaseEntity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(ShowcaseEntity showcaseEntity)
    {
        var _showcaseEntity = await _context.Showcases.FirstOrDefaultAsync(x => x.Id == showcaseEntity.Id);
        if (_showcaseEntity != null)
        {
            _context.Remove(_showcaseEntity);
            await _context.SaveChangesAsync();
        }
    }
}
