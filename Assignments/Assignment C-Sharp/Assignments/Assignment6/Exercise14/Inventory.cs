using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6.Exercise14
{
    class Inventory
    {
        private void CreateProduct(Dictionary<Product, int> products)
        {
            int id = (new Random()).Next(1000, 10000);
            int price = (new Random()).Next(10, 100);
            int quantity = (new Random()).Next(1, 10);
            bool isDefective = Convert.ToBoolean((new Random()).Next(0, 1));
            Console.WriteLine("The product ID: {0}", id);
            Console.WriteLine("The product price: {0}", price);
            Console.WriteLine("Enter the product quantities: {0}", quantity);
            Console.Write("Is this product defective? : {0}", isDefective);

            Product p = new Product(id, price, isDefective);
            if (!isDefective)
            {
                products.Add(p, quantity);
                Console.WriteLine("\nA new product has been added.\n");
            }
            else
            {
                products.Add(p, 0);
                Console.WriteLine("\nProduct is Defective\n");
            }
        }

        private void RemoveProduct(Dictionary<Product, int> products)
        {
            if(!products.Any())
            {
                Console.WriteLine("\nNo products has been added yet.\n");
                return;
            }
            ShowAllProducts(products);
            Console.Write("Enter the product ID to remove: ");
            int id = int.Parse(Console.ReadLine());
            Product selectedProduct = null;
            foreach (var product in products)
            {
                if (product.Key.Id == id)
                {
                    selectedProduct = product.Key;
                    break;
                }
            }
            if (selectedProduct != null)
            {
                products.Remove(selectedProduct);
                Console.WriteLine("\nThe product has been removed.\n");
            }
            else
            {
                Console.WriteLine("\nA product does not exist.\n");
            }
        }
        
        private void UpdateProductQuantity(Dictionary<Product, int> products)
        {
            if (!products.Any())
            {
                Console.WriteLine("\nNo products has been added yet.\n");
                return;
            }
            ShowAllProducts(products);
            Console.Write("Enter the product ID to update product quantity: ");
            int id = int.Parse(Console.ReadLine());
            Product selectedProduct = null;
            foreach (var product in products)
            {
                if (product.Key.Id == id)
                {
                    selectedProduct = product.Key;
                    break;
                }
            }
            if (selectedProduct != null)
            {
                Console.Write("Enter a new product quantities: ");
                int quantity = int.Parse(Console.ReadLine());
                products[selectedProduct] = quantity;
                Console.WriteLine("\nThe product quantity has been updated.\n");
            }
            else
            {
                Console.WriteLine("\nA product does not exist.\n");
            }
        }

        private void TotalValue(Dictionary<Product, int> products)
        {
            int total = 0;
            foreach (var product in products)
            {
                total += product.Key.Price * product.Value;
            }
            Console.WriteLine("The total value of the inventory: {0}\n", total);
        }

        private void ShowAllProducts(Dictionary<Product, int> products)
        {
            if (products.Any())
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-15}{3,-15}", "ID", "Price", "IsDefective", "Quantity");
                foreach (var product in products)
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", product.Key.Id, product.Key.Price, 
                        product.Key.IsDefective, product.Value);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any product yet.");
            }
            Console.WriteLine();
        }

        public Inventory()
        {
            Dictionary<Product, int> products = new Dictionary<Product, int>();

            int ch = -1;
            while (ch != 0)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Product Quantity");
                Console.WriteLine("4. Show All Products");
                Console.WriteLine("5. Display total value of the inventory");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice : ");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        CreateProduct(products);
                        break;
                    case 2:
                        RemoveProduct(products);
                        break;
                    case 3:
                        UpdateProductQuantity(products);
                        break;
                    case 4:
                        ShowAllProducts(products);
                        break;
                    case 5:
                        TotalValue(products);
                        break;
                    case 0:
                        //exit
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
