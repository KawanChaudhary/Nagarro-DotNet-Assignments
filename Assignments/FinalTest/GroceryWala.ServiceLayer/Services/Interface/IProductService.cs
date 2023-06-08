using GroceryWala.DomainLayer.Models.Single;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryWala.DataServiceLayer.Services.Interface
{
    public interface IProductService
    {
        Task<int> AddNewProduct(ProductModel product);

        Task<ImageModel> AddImages(ImageModel image);

        Task<List<ProductModel>> GetAllProductsDetails();
        Task<List<ImageModel>> GetAllProductsImages();
        Task<List<ProductModel>> GetProductsByCategory(int category);

        Task<ProductModel> GetProductById(int productId);
    }
}
