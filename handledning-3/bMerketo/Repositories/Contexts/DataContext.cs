using Microsoft.EntityFrameworkCore;
using Repositories.Models.Entities;

namespace Repositories.Contexts;

public class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ShowcaseEntity> Showcases { get; set; }
}
