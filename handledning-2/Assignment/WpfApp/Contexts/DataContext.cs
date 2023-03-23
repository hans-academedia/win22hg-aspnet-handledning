using Microsoft.EntityFrameworkCore;
using WpfApp.Models.Entities;

namespace WpfApp.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HansMattin-Lassei\OneDrive - EPN Sverige AB\Documents\Utbildning\Education\WIN22HG\handledning-2\Assignment\WpfApp\Contexts\wpf-sql-database.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>(entity => entity.HasIndex(e => e.Email).IsUnique());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<CaseEntity> Cases { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<StatusEntity> Statuses { get; set; }
    }
}
