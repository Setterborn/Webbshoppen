using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Webbshoppen.Models;

namespace Webbshoppen.Data
{
    [BindProperties]
    public class ProductManager
    {
        public static string AddProductResponse { get; set; }
        public static double TempTotal { get; set; }
        public static int TempProductId { get; set; }
        public static int Discount { get; set; } = 20;
        public static List<Product> ProductList { get; set; } = new();
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
                    SortedList = ProductList;
                    break;
                case 2:
                    SortedList = ProductList.Where(p => p.Gender is Models.Gender.Male).ToList();
                    break;
                case 3:
                    SortedList = ProductList.Where(p => p.Gender is Models.Gender.Female).ToList();
                    break;
                case 4:
                    SortedList = ProductList.Where(p => p is Models.Jackets).ToList();
                    break;
                case 5:
                    SortedList = ProductList.Where(p => p is Models.Shoes).ToList();
                    break;
                case 6:
                    SortedList = ProductList.Where(p => p is Models.Shirts).ToList();
                    break;
                case 7:
                    SortedList = ProductList.Where(p => p is Models.Pants).ToList();
                    break;
                case 8:
                    SortedList = ProductList.Where(p => p is Models.Underwear).ToList();
                    break;
                case 9:
                    SortedList = new();
                    var nameSearch = ProductList.Where(p => p.Name.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var descriptionSearch = ProductList.Where(p => p.Description.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var colorSearch = ProductList.Where(p => p.Colors.ToString().ToLower().Contains(SearchInput.ToLower())).ToList();
                    SortedList.AddRange(nameSearch);
                    SortedList.AddRange(descriptionSearch);
                    SortedList.AddRange(colorSearch);
                    break;
                case 10:
                    SortedList = SalesList;
                    break;
            }
        }
        public static void PostProduct(Product productToPost)
        {
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            string serialized = JsonConvert.SerializeObject(productToPost);
            StringContent stringToSend = new StringContent(serialized, Encoding.UTF8, "application/json");
            switch (productToPost)
            {
                case Underwear:
                    response = httpClient.PostAsync("https://localhost:44397/addunderwear", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Pants:
                    response = httpClient.PostAsync("https://localhost:44397/addpants", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shirts:
                    response = httpClient.PostAsync("https://localhost:44397/addshirts", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shoes:
                    response = httpClient.PostAsync("https://localhost:44397/addshoes", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Jackets:
                    response = httpClient.PostAsync("https://localhost:44397/addjackets", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
            }
        }
        public static List<Product> GetProductList()
        {
            var httpClient = new HttpClient();
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var response = httpClient.GetAsync("https://localhost:44397/getproducts").GetAwaiter().GetResult();
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
                temp.Price = Math.Round(temp.Price * discount);
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
