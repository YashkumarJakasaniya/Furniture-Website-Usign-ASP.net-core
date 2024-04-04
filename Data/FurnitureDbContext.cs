using FURNITURE.Models;
using Microsoft.EntityFrameworkCore;

namespace FURNITURE.Data
{
    public class FurnitureDbContext : DbContext
    {
        public FurnitureDbContext()
        {
        }

        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options)
        {

        }

        public DbSet<FurnitureDataModel> FurnitureData { get; set; }
        public DbSet<ProductsDataModel> ProductsData { get; set; }
        public DbSet<SofaDataModel>SofaData { get; set; }
        public DbSet<ChairDataModel>Chairtbl { get; set; }
        public DbSet<AddCart>CartData { get; set; }
        public DbSet<OrderData> OrderData{ get; set; }
        public DbSet<CheckoutViewModel> CheckoutData{ get; set; }

    }

}
