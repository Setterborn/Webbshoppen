using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webbshoppen.Pages
{
    public class ViewCartModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(int input)
        {
            foreach (Models.Product prod in Data.ProductManager.Cart)
            {
                if(prod.ProductId == input) { Data.ProductManager.Cart.Remove(prod); break; } 
            }
            return Page();
        }
    }
}
