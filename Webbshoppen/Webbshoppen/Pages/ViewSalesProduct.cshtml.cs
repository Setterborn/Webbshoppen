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
        public int NumberOfItems { get; set; }
        public int ProductId { get; set; }

        public void OnGet(int productId)
        {
            ProductId = productId;
            TheProduct = ProductManager.SalesList[productId];
        }
        public IActionResult OnPost(int input)
        {
            if (ProductManager.SalesList[ProductId].Stock >= input)
            {
                for (int i = 0; i < input; i++)
                {
                    ProductManager.Cart.Add(ProductManager.SalesList[ProductId]);
                    ProductManager.SalesList[ProductId].Stock--;
                }
            }
            return RedirectToPage("/ViewCart");
        }
    }
}
