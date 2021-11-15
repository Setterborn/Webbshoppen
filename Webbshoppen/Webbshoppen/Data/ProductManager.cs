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
        public static double TempTotal { get; set; }
        public static int TempProductId { get; set; }
        public static int Discount { get; set; } = 20;
        public static List<Product> ProductList { get; set; } = GetProductList();
        public static List<Product> SortedList { get; set; } = new();
        public static List<Product> SalesList { get; set; } = new();
        public static List<Product> Cart { get; set; } = new();
        [BindProperty(SupportsGet = true)]
        public static string SearchInput { get; set; } = " ";
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
        public static void GetRandomSalesProduct()
        {
            SalesList = new();
            float discount = 100 - Discount;
            discount = discount / 100;
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new();
                var rndInt = rnd.Next(0, ProductList.Count);
                Product temp = new();
                if (ProductList[rndInt] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[rndInt]); }
                if (ProductList[rndInt] is Pants) { temp = Pants.Clone((Pants)ProductList[rndInt]); }
                if (ProductList[rndInt] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[rndInt]); }
                if (ProductList[rndInt] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[rndInt]); }
                if (ProductList[rndInt] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[rndInt]); }
                temp.Price = Math.Round(ProductList[rndInt].Price * discount);
                SalesList.Add(temp);
            }
        }
        public static void OrderProductList()
        {
            ProductList = ProductList.OrderBy(p => p.ProductId).ToList();
        }
        public static void AddSalesProduct(int productId)
        {
            Product temp = new();
            if (ProductList[productId] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[productId]); }
            if (ProductList[productId] is Pants) { temp = Pants.Clone((Pants)ProductList[productId]); }
            if (ProductList[productId] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[productId]); }
            if (ProductList[productId] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[productId]); }
            if (ProductList[productId] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[productId]); }
            SalesList.Add(temp);
        }
        public static void UpdateSalesList()
        {
            float discount = 100 - Discount;
            discount = discount / 100;

            for (int i = 0; i < SalesList.Count; i++)
            {
                Product temp = new();
                int productId = SalesList[i].ProductId;
                SalesList.RemoveAll(p => p.ProductId == productId);
                if (ProductList[productId] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[productId]); }
                if (ProductList[productId] is Pants) { temp = Pants.Clone((Pants)ProductList[productId]); }
                if (ProductList[productId] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[productId]); }
                if (ProductList[productId] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[productId]); }
                if (ProductList[productId] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[productId]); }
                temp.Price = Math.Round(temp.Price * discount);
                SalesList.Add(temp);
            }
        }
    }
}
