using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            return RedirectToPage("/ViewCart");
        }
    }
}
