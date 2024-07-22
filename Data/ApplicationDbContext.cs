using Microsoft.EntityFrameworkCore;
using ProjectEcommerce.Models;

namespace ProjectEcommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { CategoeyID = 1, CategoryName = "Dress", CategoryDescription = "All of Clothing", DisplayOrder = 1},
                new CategoryModel { CategoeyID = 2, CategoryName = "Skirt", CategoryDescription = "All of Clothing", DisplayOrder = 2 },
                new CategoryModel { CategoeyID = 3, CategoryName = "Cost", CategoryDescription = "All of Clothing", DisplayOrder = 3 }
                );
        }
    }
}
