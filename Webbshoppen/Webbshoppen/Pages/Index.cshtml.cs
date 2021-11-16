using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Skriva class som det ska hämtas från!

namespace Webbshoppen.Pages
{
    public class IndexModel : PageModel
    {
       
        public string FindProduct { get; set; }

        public int Index { get; set; }

        public string ShopName { get; set; }
        
        

        public void OnGet(int index)
        {
          

            ShopName = "Comfortable Store";
            
        }
       /* public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)

            {
                return Page();
            }
            
            return ViewSortedList();
        }*/
    }
}
