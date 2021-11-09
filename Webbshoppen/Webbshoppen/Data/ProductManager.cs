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
        public static List<Product> GetProductList()
        {
            // 

            var httpClient = new HttpClient();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var response = httpClient.GetAsync("https://localhost:44397/Products").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return JsonSerializer.Deserialize<List<Product>>(apiResponse, options);
        }
    }
}
