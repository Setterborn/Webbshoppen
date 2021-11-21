using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshoppen.Models;
using Webbshoppen.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Webbshoppen.Pages
{
    [BindProperties]
    public class ViewProductModel : PageModel
    {
        public Product TheProduct { get; set; }
        public int ProductId { get; set; }

        public void OnGet(int productId)
        {
            ProductId = productId;
            TheProduct = ProductManager.ProductList[productId];
        }
        //Tar emot antalet produkter som skall läggas till i varukorgen
        public IActionResult OnPost(int input)
        {
            if (ProductManager.ProductList[ProductId].Stock >= input)
            {
                //Lägger till produkgter och minskar lagersaldot
                for (int i = 0; i < input; i++)
                {
                    ProductManager.Cart.Add(ProductManager.ProductList[ProductId]);
                    ProductManager.ProductList[ProductId].Stock--;
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
