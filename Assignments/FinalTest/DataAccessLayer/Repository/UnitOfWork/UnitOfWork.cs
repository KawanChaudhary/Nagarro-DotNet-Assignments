using GroceryWala.DataAccessLayer.Repository.Concrete;
using GroceryWala.DataAccessLayer.Repository.Interface;
using System;
using System.Threading.Tasks;

namespace GroceryWala.DataAccessLayer.Repository.UnitOfWork
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly GroceryWalaContext _context;

        public IProductRepository ProductRepository { get; set; }
        public IImageRepository ImageRepository { get; set; }

        public UnitOfWork(GroceryWalaContext context)
        {
            _context = context;

            ProductRepository = new ProductRepository(context);
            ImageRepository = new ImageRepository(context);

        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
