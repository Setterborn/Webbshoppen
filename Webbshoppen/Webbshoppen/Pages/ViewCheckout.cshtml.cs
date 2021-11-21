using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

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
        public int ShippingCost { get; set; }
        public Models.Payment PaymentOption { get; set; }
        public void OnGet()
        {
            //Summerar alla produkterna i varukorgen till totalpris
            foreach (Models.Product prod in Data.ProductManager.Cart)
            {
                Total += prod.Price;
            }
            Data.ProductManager.TempTotal = Total;
            CState = 0;
        }
        public IActionResult OnPost(int input)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            switch (input)
            {
                case 1:
                    CState = input;
                    break;
                case 2:
                    if (ModelState.IsValid) { CState = input; } else { CState = 5; }
                    if(ShippingOption==Models.Shipping.Express) { ShippingCost = 99; } else { ShippingCost = 59; }
                    break;
                case 3://Kontrollerar kreditkortnummrets längd skall vara 10 siffror
                    if (ModelState.IsValid) { if (CCNumber.ToString().Length > 9 && CCNumber.ToString().Length <11) { CState = input; Data.ProductManager.Cart=new(); var cartString = JsonConvert.SerializeObject(Data.ProductManager.Cart, settings);
                            Response.Cookies.Append("MyCookie", cartString, cookieOptions);
                        } else { CState = 4; } } else { CState = 5; }
                    break;
                case 4:
                    Data.ProductManager.Cart = new();
                    var cartString2 = JsonConvert.SerializeObject(Data.ProductManager.Cart, settings);
                    Response.Cookies.Append("MyCookie", cartString2, cookieOptions);
                    CState = 3;
                    break;
                case 10:
                    if (ShippingOption == Models.Shipping.Express) { ShippingCost = 99; } else { ShippingCost = 59; }
                    if(PaymentOption == Models.Payment.CreditCard) { CState = 2; }else { CState = 6; }
                    break;
            }
            return Page();
        }
    }
}
