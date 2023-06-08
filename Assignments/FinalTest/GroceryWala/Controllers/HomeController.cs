using GroceryWala.DataServiceLayer.Services.Interface;
using GroceryWala.DomainLayer.Models.Multiple;
using GroceryWala.DomainLayer.Models.Single;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryWala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return Ok("Success From Home");
        }

        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetProductsByCategory(int category)
        {
            try
            {

                var products = await productService.GetProductsByCategory(category);

                var images = await productService.GetAllProductsImages();

                var res = new List<AllProductModel>();

                foreach (var product in products)
                {
                    string productId = product.Id.ToString();
                    var productImages = new List<ImageModel>();
                    foreach (var image in images)
                    {
                        if (productId == image.ProductId)
                        {
                            productImages.Add(new ImageModel()
                            {
                                Id = image.Id,
                                ProductId = image.ProductId,
                                ImageAddress = "http://127.0.0.1:8080/images/" + image.ImageAddress.Substring(97)
                            });
                        }
                    }
                    res.Add(new AllProductModel()
                    {
                        Details = product,
                        Images = productImages
                    });
                }

                return Ok(new
                {
                    response = res
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("product/{productid}")]
        public async Task<IActionResult> GetProductById(int productid)
        {
            try
            {
                ProductModel product = await productService.GetProductById(productid);

                var images = await productService.GetAllProductsImages();

                var resImages = new List<ImageModel>();

                string productId = product.Id.ToString();

                foreach (var image in images)
                {
                    if (productId == image.ProductId)
                    {
                        resImages.Add(new ImageModel()
                        {
                            Id = image.Id,
                            ProductId = image.ProductId,
                            ImageAddress = "http://127.0.0.1:8080/images/" + image.ImageAddress.Substring(97)
                        });
                    }

                }

                return Ok(new
                {
                    product = product,
                    images = resImages
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



    }
}
