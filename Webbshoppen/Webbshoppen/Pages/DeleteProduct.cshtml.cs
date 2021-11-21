using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Webbshoppen.Pages
{
    public class DeleteProductModel : PageModel
    {
        public void OnGet(int input)
        {
            foreach (Models.Product prod in Data.ProductManager.Cart)
            {
                if (prod.ProductId == input) { Data.ProductManager.Cart.Remove(prod); Data.ProductManager.ProductList[input].Stock++; break; }
            }
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var cartString = JsonConvert.SerializeObject(Data.ProductManager.Cart, settings);
            Response.Cookies.Append("MyCookie", cartString, cookieOptions);
        }
    }
}
