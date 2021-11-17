using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webbshoppen.Data;


namespace Webbshoppen.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FindProduct { get; set; }

        public int Index { get; set; }

        public string ShopName { get; set; }
        public void OnGet(int index)
        {
            ShopName = "Comfortable Clothing";
        }
       public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            Data.ProductManager.SearchInput = FindProduct;
            return RedirectToPage("ViewSortedPages",new {index = 9 });
        }
    }
}
