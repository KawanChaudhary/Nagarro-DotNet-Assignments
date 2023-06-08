using GroceryWala.DataServiceLayer.Services.Interface;
using GroceryWala.DomainLayer.Models.Multiple;
using GroceryWala.DomainLayer.Models.Single;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GroceryWala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [Produces("application/json")]
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly IWebHostEnvironment webHostEnvironement;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AdminController(IProductService _productService, IWebHostEnvironment _webHostEnvironement,
            IHttpContextAccessor _httpContextAccessor)
        {
            this.productService = _productService;
            this.webHostEnvironement = _webHostEnvironement;
            this.httpContextAccessor = _httpContextAccessor;
        }

        public IActionResult Index()
        {
            return Ok("Success From admin");
        }

        [HttpPost("addnewproduct")]

        public async Task<IActionResult> AddNewProduct(ProductModel product)
        {
            try 
            {
                int productId = await productService.AddNewProduct(product);
                
                return Ok(new { 
                    id = productId
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost("addproductimages")]

        public async Task<IActionResult> AddProductImages(IFormFile[] images)
        {
            try
            {                
                string productId = HttpContext.Request.Form["productId"];

                var baseUrl = httpContextAccessor.HttpContext.Request.Scheme + "://" +
                    httpContextAccessor.HttpContext.Request.Host +
                    httpContextAccessor.HttpContext.Request.PathBase;
                string directory = $"{webHostEnvironement.WebRootPath}\\images\\{productId}";

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                foreach (var file in images)
                {

                    var path = Path.Combine(directory, file.FileName);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    var image = new ImageModel()
                    {
                        ProductId = productId,
                        ImageAddress = path
                    };

                    var newImage = await productService.AddImages(image);

                }

                return Ok(new
                {
                    response = true
                });


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("allproducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await productService.GetAllProductsDetails();

                var images = await productService.GetAllProductsImages();

                var res = new List<AllProductModel>();

                foreach(var product in products)
                {
                    string productId = product.Id.ToString();
                    var productImages = new List<ImageModel>();
                    foreach(var image in images)
                    {
                        if(productId == image.ProductId)
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

                return Ok(new { 
                    response = res
                });

            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /*      [HttpPost("addimages")]

              public async  Task<IActionResult> AddImages(IFormFile[] images)
              {
                  try
                  {
                      string productId = HttpContext.Request.Form["productId"];

                      var baseUrl = httpContextAccessor.HttpContext.Request.Scheme + "://" +
                          httpContextAccessor.HttpContext.Request.Host +
                          httpContextAccessor.HttpContext.Request.PathBase;
                      string directory = $"{webHostEnvironement.WebRootPath}\\images\\{productId}";

                      if (!Directory.Exists(directory))
                      {
                          Directory.CreateDirectory(directory);
                      }

                      var res = new List<ImageModel>();

                      foreach (var file in images)
                      {

                          var path = Path.Combine(directory, file.FileName);

                          var image = new ImageModel()
                          {
                              ProductId = productId,
                              ImageAddress = path
                          };

                          var newImage = await productService.AddImages(image);

                          res.Add(newImage);                    
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
      */

    }
}
