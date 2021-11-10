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
    public class ProductManager
    {
        public static List<Product> ProductList { get; set; } = GetProductList();
        public static List<Product> SortedList { get; set; }

        public static List<Product> UpdateProductId(List<Product> productList)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].ProductId = i;
            }
            return productList;
        }
        public static List<Product> GetProductList()
        {
            // 

            var httpClient = new HttpClient();

            JsonSerializerSettings settings = new JsonSerializerSettings 
            { 
                TypeNameHandling = TypeNameHandling.Auto 
            };

            var response = httpClient.GetAsync("https://localhost:44397/Products").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            apiResponse = apiResponse.Replace("WebbshoppenAPI", "Webbshoppen");
            var ProductList = JsonConvert.DeserializeObject<List<Product>>(apiResponse, settings);
            return ProductList;
        }
    }
}
