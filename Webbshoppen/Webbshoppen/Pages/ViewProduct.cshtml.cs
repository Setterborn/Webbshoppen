using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshoppen.Models;
using Webbshoppen.Data;

namespace Webbshoppen.Pages
{
    public class ViewProductModel : PageModel
    {
        public List<Product> Productlist { get; set; }

        public void OnGet()
        {
            Productlist = ProductManager.GetProductList();
        }
    }
}
