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
        public string SizeStr { get; set; }
        public JacketLenght JacketLenght { get; set; }
        public UnderwearSexyness UnderwearSexyness { get; set; }
        public void OnGet()
        {
            CState = 0;
        }
        public IActionResult OnPost(int input)
        {
            //Sätter CState till input om input är mindre än 100
            if (input < 100) { CState = input; }
            //Bestämmer vilken produkt vi vill ändra genom Edit
            if (input == 12) { ProductManager.TempProductId = ProductId; TheProduct = ProductManager.ProductList[ProductManager.TempProductId];ProductManager.TempProduct = TheProduct; }
            //Hämta random rea produkter
            if (input == 13) { ProductManager.GetRandomSalesProduct(); }
            //Hämta test produkter från API
            if (input == 14) { ProductManager.ProductList = ProductManager.GetTestProductList(); }
            //Hämta produkter från API
            if (input == 15) { ProductManager.ProductList = ProductManager.GetProductList(); }
            //Lägga till nya produkter
            else if (input == 100) //Skapar en jacket
            {
                if (ModelState.IsValid) 
                {
                    //Skapa ny produkt
                    Product temp = new Jackets(ProductManager.ProductList.Count, SizeStr, Colors, Gender, Name, Price, Description, Stock, JacketLenght, ImageLink);
                    //Lägga till ny produkt i listan
                    ProductManager.ProductList.Add(temp);
                    //Skicka ny produkt till API
                    ProductManager.PostProduct(temp);
                    CState = 100; 
                } else 
                { 
                    CState = 101; 
                } 
            }
            else if (input == 101) //Skapar en Pants
            { 
                if (ModelState.IsValid) 
                {
                    Product temp = new Pants(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                    ProductManager.ProductList.Add(temp);
                    ProductManager.PostProduct(temp);
                    CState = 100; 
                } else 
                { 
                    CState = 101;
                } 
            }
            else if (input == 102) // Skapar en Shirts
            { 
                if (ModelState.IsValid) 
                {
                    Product temp = new Shirts(ProductManager.ProductList.Count, SizeStr, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                    ProductManager.ProductList.Add(temp);
                    ProductManager.PostProduct(temp);
                    CState = 100;
                } else 
                { 
                    CState = 101;
                } 
            }
            else if (input == 103) // Skapar en Shoes
            { 
                if (ModelState.IsValid) 
                {
                    Product temp = new Shoes(ProductManager.ProductList.Count, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                    ProductManager.ProductList.Add(temp);
                    ProductManager.PostProduct(temp);
                    CState = 100; 
                } else 
                { 
                    CState = 101;
                }
            }
            else if (input == 104) //Skapar en Underwear
            { 
                if (ModelState.IsValid) 
                {
                    Product temp = new Underwear(ProductManager.ProductList.Count, SizeStr, Colors, Gender, Name, Price, Description, Stock, UnderwearSexyness, ImageLink);
                    ProductManager.ProductList.Add(temp);
                    ProductManager.PostProduct(temp);
                    CState = 100;
                } else 
                { 
                    CState = 101; 
                } 
            }
            //Tar bort produkt ur produktlistan efter produktid
            else if (input == 105) { if (ModelState.IsValid) { ProductManager.DeleteProduct(ProductId); CState = 130; } }
            //Ändrar och updaterar discount
            else if (input == 106) { ProductManager.Discount = Discount; ProductManager.UpdateSalesList(); CState = 104; }
            //Ändra en produkt
            else if (input == 107)
            {
                    if (ProductManager.TempProduct is Jackets) 
                    { 
                        Jackets jacket = new Jackets(ProductManager.TempProductId, SizeStr, Colors, Gender, Name, Price, Description, Stock, JacketLenght, ImageLink);
                        ProductManager.PutProduct(jacket);
                    }
                    if (ProductManager.TempProduct is Pants) 
                    { 
                        Pants pants = new Pants(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                        ProductManager.PutProduct(pants);
                    }
                    if (ProductManager.TempProduct is Shirts) 
                    { 
                        Shirts shirts = new Shirts(ProductManager.TempProductId, SizeStr, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                        ProductManager.PutProduct(shirts);
                    }
                    if (ProductManager.TempProduct is Shoes) 
                    {
                        Shoes shoes = new Shoes(ProductManager.TempProductId, Size, Colors, Gender, Name, Price, Description, Stock, ImageLink);
                        ProductManager.PutProduct(shoes);
                    }
                    if (ProductManager.TempProduct is Underwear) 
                    { 
                        Underwear underwear = new Underwear(ProductManager.TempProductId, SizeStr, Colors, Gender, Name, Price, Description, Stock, UnderwearSexyness, ImageLink);
                        ProductManager.PutProduct(underwear);
                    }
                    if (ProductManager.TempProductId < ProductManager.ProductList.Count) { CState = 105; }
                        
                    else { CState = 106; }
                ProductManager.ProductList = ProductManager.GetProductList();
            }
            //Lägg till reaprodukt
            if (input == 108) { ProductManager.AddSalesProduct(ProductId); ProductManager.UpdateSalesList(); CState = 107; }
            //Ta bort produkt från realistan
            if (input == 109) { ProductManager.SalesList.RemoveAll(p => p.ProductId == ProductId); CState = 108; }
            //Sorterar produktlistan
            ProductManager.OrderProductList();
            return Page();
        }
    }
}
