using GroceryWala.DataAccessLayer.Repository.Interface;
using System.Threading.Tasks;

namespace GroceryWala.DataAccessLayer.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; set; }

        IImageRepository ImageRepository { get; set; }

        Task CompleteAsync();
        void Dispose();
    }
}