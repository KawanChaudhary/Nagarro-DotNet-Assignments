using GroceryWala.DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryWala.DataAccessLayer
{
    public class GroceryWalaContext : DbContext
    {
        public GroceryWalaContext(DbContextOptions<GroceryWalaContext> options) : base(options)
        {

        }

        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<ImageEntity> Images { get; set; }


    }
}
