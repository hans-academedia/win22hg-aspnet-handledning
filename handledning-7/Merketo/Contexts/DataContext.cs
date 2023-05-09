using Merketo.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Contexts
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<ProductTagEntity> ProductTags { get; set; }
        public DbSet<ContactFormEntity> ContactForms { get; set; }


        //public DbSet<CategoryEntity> Categories { get; set; }
        //public DbSet<ImageEntity> Images { get; set; }
        //public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        //public DbSet<ProductImageEntity> ProductImages { get; set; }
        //public DbSet<ProductReviewEntity> ProductReviews { get; set; }
        //public DbSet<VendorEntity> Vendors { get; set; }
    }
}
