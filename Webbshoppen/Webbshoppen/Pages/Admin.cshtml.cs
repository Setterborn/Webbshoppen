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
    [BindProperties(SupportsGet = true)]
    public class AdminModel : PageModel
    {
        public Product TheProduct { get; set; }
        public string Type { get; set; }
        public int Discount { get; set; }
        public int CState { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } 
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageLink { get; set; }
        public Colors Colors { get; set; }
        public Gender Gender { get; set; }
        public int Size { get; set; }
        public JacketLenght JacketLenght { get; set; }
        public UnderwearSexyness UnderwearSexyness { get; set; }
        public void OnGet()
        {
            CState = 0;
        }
        public IActionResult OnPost(int input)
        {
            if (input < 100) { CState = input; }
            if (input == 12) { ProductManager.TempProductId = ProductId; TheProduct = ProductManager.ProductList[ProductManager.TempProductId];}
            if (input == 13) { ProductManager.GetRandomSalesProduct(); }
            else if (input == 100) { if (ModelState.IsValid) { ProductManager.ProductList.Add(new Jackets(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, JacketLenght, ImageLink)); CState = 100; } else { CState = 101; } }
            else if (input == 101) { if (ModelState.IsValid) { ProductManager.ProductList.Add(new Pants(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); CState = 100; } else { CState = 101; } }
            else if (input == 102) { if (ModelState.IsValid) { ProductManager.ProductList.Add(new Shirts(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); CState = 100; } else { CState = 101; } }
            else if (input == 103) { if (ModelState.IsValid) { ProductManager.ProductList.Add(new Shoes(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); CState = 100; } else { CState = 101; } }
            else if (input == 104) { if (ModelState.IsValid) { ProductManager.ProductList.Add(new Underwear(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, UnderwearSexyness, ImageLink)); CState = 100; } else { CState = 101; } }
            else if (input == 105) { if (ModelState.IsValid) { ProductManager.ProductList.RemoveAll(p => p.ProductId == ProductId); if (ProductId < ProductManager.ProductList.Count) { CState = 102; } else { CState = 103; } } }
            else if (input == 106) { ProductManager.Discount = Discount; ProductManager.UpdateSalesList(); CState = 104; }
            else if (input == 107)
            {
                if (ModelState.IsValid)
                {
                    ProductManager.ProductList.RemoveAll(p => p.ProductId == ProductManager.TempProductId);
                    if (Type == "Jackets") { ProductManager.ProductList.Add(new Jackets(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, JacketLenght, ImageLink)); }
                    if (Type == "Pants") { ProductManager.ProductList.Add(new Pants(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); }
                    if (Type == "Shirts") { ProductManager.ProductList.Add(new Shirts(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); }
                    if (Type == "Shoes") { ProductManager.ProductList.Add(new Shoes(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink)); }
                    if (Type == "Underwear") { ProductManager.ProductList.Add(new Underwear(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, UnderwearSexyness, ImageLink)); }
                    if (ProductManager.TempProductId < ProductManager.ProductList.Count) { CState = 105; }
                    else { CState = 106; }
                }
            }
            if (input == 108) { ProductManager.AddSalesProduct(ProductId); ProductManager.UpdateSalesList(); CState = 107; }
            if (input == 109) { ProductManager.SalesList.RemoveAll(p => p.ProductId == ProductId); CState = 108; }
            ProductManager.OrderProductList();
            return Page();
        }
    }
}
