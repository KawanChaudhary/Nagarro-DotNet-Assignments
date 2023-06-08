using GroceryWala.DataAccessLayer.Repository.UnitOfWork;
using GroceryWala.DataServiceLayer.Services.Interface;
using GroceryWala.DomainLayer.Entities;
using GroceryWala.DomainLayer.Models.Single;
using GroceryWala.DomainLayer.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryWala.DataServiceLayer.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<int> AddNewProduct(ProductModel product)
        {
            var newProduct = new ProductEntity()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                Stock = product.Stock,
                Category = product.Category,
                SizeType = product.SizeType,
                Quantity = product.Quantity,
                OtherDetails = product.OtherDetails,

                ModifiedOn = DateTime.UtcNow,
                CreatedOn = DateTime.UtcNow

            };
            await unitOfWork.ProductRepository.Add(newProduct);
            await unitOfWork.CompleteAsync();

            return newProduct.Id;
        }

        public async Task<ImageModel> AddImages(ImageModel image)
        {
            var newImage = new ImageEntity()
            {
                ProductId = image.ProductId,
                ImageAddress = image.ImageAddress,
            };

            await unitOfWork.ImageRepository.Add(newImage);
            await unitOfWork.CompleteAsync();
            image.Id = newImage.Id;
            return image;
        }


        public async Task<List<ProductModel>> GetAllProductsDetails()
        {
            var products = await unitOfWork.ProductRepository.All();

            var res = new List<ProductModel>();

            if (products?.Any() == true)
            {
                foreach (var product in products)
                {
                    res.Add(new ProductModel()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Discount = product.Discount,
                        Stock = product.Stock,
                        Category = product.Category,
                        SizeType = product.SizeType,
                        Quantity = product.Quantity,
                        OtherDetails = product.OtherDetails,
                    }); ;
                }
            }
            return res;
        }

        public async Task<List<ImageModel>> GetAllProductsImages()
        {
            var images = await unitOfWork.ImageRepository.All();

            var res = new List<ImageModel>();

            if (images?.Any() == true)
            {
                foreach (var image in images)
                {
                    res.Add(new ImageModel()
                    {
                        Id = image.Id,
                        ProductId = image.ProductId,
                        ImageAddress = image.ImageAddress

                    });
                }
            }
            return res;
        }

        public async Task<List<ProductModel>> GetProductsByCategory(int category)
        {
            var products = await unitOfWork.ProductRepository.All();

            var res = new List<ProductModel>();

            if (products?.Any() == true)
            {
                foreach (var product in products)
                {
                    if (product.Category == (CategoryType)category)
                    {

                        res.Add(new ProductModel()
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Description = product.Description,
                            Price = product.Price,
                            Discount = product.Discount,
                            Stock = product.Stock,
                            Category = product.Category,
                            SizeType = product.SizeType,
                            Quantity = product.Quantity,
                            OtherDetails = product.OtherDetails,
                        }); ;
                    }
                }
            }
            return res;
        }

        public async Task<ProductModel> GetProductById(int productId)
        {

            var product = await unitOfWork.ProductRepository.GetById(productId);

            var resProduct = new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                Stock = product.Stock,
                Category = product.Category,
                SizeType = product.SizeType,
                Quantity = product.Quantity,
                OtherDetails = product.OtherDetails,
            };
            return resProduct;

        }

    }
}
