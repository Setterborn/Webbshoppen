using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webbshoppen.Pages
{
    [BindProperties(SupportsGet = true)]
    public class ViewCheckoutModel : PageModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public Models.Shipping ShippingOption { get; set; }
        public int CState { get; set; }
        public double Total { get; set; }
        public int CCNumber { get; set; }
        public void OnGet()
        {
            foreach (Models.Product prod in Data.ProductManager.Cart)
            {
                Total += prod.Price;
            }
            Data.ProductManager.TempTotal = Total;
            CState = 0;
        }
        public IActionResult OnPost(int input)
        {
            switch (input)
            {
                case 1:
                    CState = input;
                    break;
                case 2:
                    if (ModelState.IsValid) { CState = input; } else { CState = 5; }
                    break;
                case 3:
                    if (ModelState.IsValid) { if (CCNumber.ToString().Length > 9 && CCNumber.ToString().Length <11) { CState = input; Data.ProductManager.Cart.Clear(); } else { CState = 4; } } else { CState = 5; }
                    break;
            }
            return Page();
        }
    }
}
