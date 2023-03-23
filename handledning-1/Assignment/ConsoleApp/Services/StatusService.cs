using ConsoleApp.Contexts;
using ConsoleApp.Models.Entitites;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Services;

internal class StatusService
{
    private readonly DataContext _context = new();

    public async Task CreateStatusTypesAsync()
    {
        if (!await _context.Statuses.AnyAsync())
        {
            string[] _statuses = new string[] { "Ej påbörjad", "Pågående", "Avslutad" };

            foreach(var status in _statuses)
            {
                await _context.AddAsync(new StatusEntity { StatusName = status });
                await _context.SaveChangesAsync();
            }
        }
    }
}
