using GroceryWala.DomainLayer.Other;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryWala.DomainLayer.Models.Single
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The Price field must be a positive number.")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The Quantity field must be a positive number.")]
        public decimal Quantity { get; set; }

        [Required(ErrorMessage = "The Category field is required.")]
        public CategoryType Category { get; set; }

        [Required(ErrorMessage = "The Description is required.")]
        [StringLength(500, ErrorMessage = "The Description field cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The Stock field must be a non-negative number.")]
        public int Stock { get; set; }

        [Range(0, 100, ErrorMessage = "The Stock field must be a non-negative number.")]
        public int Discount { get; set; }

        [Required]
        public SizeType SizeType { get; set; }

        public decimal Rating { get; set; }

        public int TotalRatings { get; set; }

        public string OtherDetails { get; set; }

        public int ReviewCount { get; set; }
    }
}
