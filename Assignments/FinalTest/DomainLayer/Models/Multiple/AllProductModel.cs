using GroceryWala.DomainLayer.Models.Single;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryWala.DomainLayer.Models.Multiple
{
    public class AllProductModel
    {
        public ProductModel Details { get; set; }
        public List<ImageModel> Images { get; set; }
    }
}
