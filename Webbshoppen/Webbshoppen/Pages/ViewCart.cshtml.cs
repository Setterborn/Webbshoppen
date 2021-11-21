using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Webbshoppen.Pages
{
    [BindProperties(SupportsGet = true)]
    public class ViewCartModel : PageModel
    {
        public int TempProductId { get; set; }
        public IEnumerable<IGrouping<int, Models.Product>> CartList { get; set; }
        public void OnGet()
        {
            var cookieValue = Request.Cookies["MyCookie"];
            if (cookieValue != null) 
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                Data.ProductManager.Cart = JsonConvert.DeserializeObject<List<Models.Product>>(cookieValue, settings); 
            }
            CartList = Data.ProductManager.Cart.GroupBy(p => p.ProductId);
        }
    }
}
