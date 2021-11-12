using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Webbshoppen.Models;

namespace Webbshoppen.Data
{
    [BindProperties]
    public class ProductManager
    {
        public static List<Product> ProductList { get; set; } = GetProductList();
        public static List<Product> SortedList { get; set; } = new();
        public static List<Product> SalesList { get; set; } = GetSalesProduct();
        public static List<Product> Cart { get; set; } = new();
        [BindProperty(SupportsGet = true)]
        public static string SearchInput { get; set; }
        public static List<Product> UpdateProductId(List<Product> productList)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].ProductId = i;
            }
            return productList;
        }
        public static void SortList(int index)
        {
            switch (index)
            {
                case 1:
                    ProductManager.SortedList = ProductManager.ProductList;
                    break;
                case 2:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p.Gender is Models.Gender.Male).ToList();
                    break;
                case 3:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p.Gender is Models.Gender.Female).ToList();
                    break;
                case 4:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Jackets).ToList();
                    break;
                case 5:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Shoes).ToList();
                    break;
                case 6:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Shirts).ToList();
                    break;
                case 7:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Pants).ToList();
                    break;
                case 8:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Underwear).ToList();
                    break;
                case 9:
                    var nameSearch = ProductManager.ProductList.Where(p => p.Name.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var descriptionSearch = ProductManager.ProductList.Where(p => p.Description.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var colorSearch = ProductManager.ProductList.Where(p => p.Colors.ToString().ToLower().Contains(SearchInput.ToLower())).ToList();
                    ProductManager.SortedList.AddRange(nameSearch);
                    ProductManager.SortedList.AddRange(descriptionSearch);
                    ProductManager.SortedList.AddRange(colorSearch);
                    break;
            }
        }
        public static List<Product> GetProductList()
        {
            var httpClient = new HttpClient();
            JsonSerializerSettings settings = new JsonSerializerSettings 
            { 
                TypeNameHandling = TypeNameHandling.Auto 
            };
            var response = httpClient.GetAsync("https://localhost:44397/Products").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            apiResponse = apiResponse.Replace("WebbshoppenAPI", "Webbshoppen");
            var ProductList = JsonConvert.DeserializeObject<List<Product>>(apiResponse, settings);
            UpdateProductId(ProductList);
            return ProductList;
        }
        public static List<Product> GetSalesProduct()
        {
            List<Product> Sales = new();
            Random rnd = new();
            var one = rnd.Next(0, ProductList.Count);
            var two = rnd.Next(0, ProductList.Count);
            var three = rnd.Next(0, ProductList.Count);
            ProductList[one].Price = Math.Round(ProductList[one].Price * 0.8);
            ProductList[two].Price = Math.Round(ProductList[two].Price * 0.8);
            ProductList[three].Price = Math.Round(ProductList[three].Price * 0.8);
            Sales.Add(ProductList[one]);
            Sales.Add(ProductList[two]);
            Sales.Add(ProductList[three]);
            return Sales; 
        }
    }
}
