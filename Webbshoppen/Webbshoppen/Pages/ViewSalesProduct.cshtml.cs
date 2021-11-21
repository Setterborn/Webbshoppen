using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Webbshoppen.Data;
using Webbshoppen.Models;

namespace Webbshoppen.Pages
{
    public class ViewSalesProductModel : PageModel
    {
        public Product TheProduct { get; set; }

        public void OnGet(int productId)
        {
            ProductManager.TempProductId = productId;
            TheProduct = ProductManager.SalesList[ProductManager.TempProductId];
        }
        public IActionResult OnPost(int input)
        {
            if (ProductManager.SalesList[ProductManager.TempProductId].Stock >= input)
            {
                for (int i = 0; i < input; i++)
                {
                    ProductManager.Cart.Add(ProductManager.SalesList[ProductManager.TempProductId]);
                    ProductManager.SalesList[ProductManager.TempProductId].Stock--;
                }
            }
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var cartString = JsonConvert.SerializeObject(ProductManager.Cart, settings);
            Response.Cookies.Append("MyCookie", cartString, cookieOptions);
            return RedirectToPage("/ViewCart");
        }
    }
}
