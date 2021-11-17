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
        public IActionResult OnPost(int input)
        {
            if (ProductManager.ProductList[ProductId].Stock >= input)
            {
                for (int i = 0; i < input; i++)
                {
                    ProductManager.Cart.Add(ProductManager.ProductList[ProductId]);
                    ProductManager.ProductList[ProductId].Stock--;     
                }
            }
            return RedirectToPage("/ViewCart");
        }
    }
}
