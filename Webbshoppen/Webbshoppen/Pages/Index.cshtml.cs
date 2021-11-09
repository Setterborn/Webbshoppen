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
        /* public List<Model.Product> Products { get; set; }
         public IEnumerable<Model.Product> FindProduct { get; set; }
         

         [BindProperty]
         public string  Shirt { get; set; }//stor eller liten bokstav på property?

         public string Pants { get; set; }

         public string Shoe {get; set;}       
         public string Underwear { get; set; }
         public string Jacket { get; set; }
         public string Female { get; set; }
         public string Male { get; set; }
         public string Unisex { get; set; }
         public string Brand { get; set; }*/


        public string ShopName { get; set; }
        
        public void OnGet()
        {
            ShopName = "Comfortable Store";
            
        }
    }
}
