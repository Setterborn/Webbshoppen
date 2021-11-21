
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Webbshoppen.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace Webbshoppen.Data
{
    [BindProperties]
    public class ProductManager
    {
        public static string AddProductResponse { get; set; }
        public static double TempTotal { get; set; }
        public static int TempProductId { get; set; }
        public static int Discount { get; set; } = 20;
        public static Product TempProduct { get; set; }
        public static List<Product> ProductList { get; set; } = GetProductList();
        public static List<Product> SortedList { get; set; } = new();
        public static List<Product> SalesList { get; set; } = new();
        public static List<Product> Cart { get; set; } = new();
        [BindProperty(SupportsGet = true)]
        public static string SearchInput { get; set; } = " ";

        //Updatera produktid i lista
        public static List<Product> UpdateProductId(List<Product> productList)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].ProductId = i;
            }
            return productList;
        }
        //Sortera lista efter linq urval beroende på val från Index sidan
        public static void SortList(int index)
        {
            switch (index)
            {
                case 1://Alla produkter
                    SortedList = ProductList;
                    break;
                case 2://Man
                    SortedList = ProductList.Where(p => p.Gender is Models.Gender.Male).ToList();
                    break;
                case 3://Kvinna
                    SortedList = ProductList.Where(p => p.Gender is Models.Gender.Female).ToList();
                    break;
                case 4://Jackor
                    SortedList = ProductList.Where(p => p is Models.Jackets).ToList();
                    break;
                case 5://Skor
                    SortedList = ProductList.Where(p => p is Models.Shoes).ToList();
                    break;
                case 6://Tröjor
                    SortedList = ProductList.Where(p => p is Models.Shirts).ToList();
                    break;
                case 7://Byxor
                    SortedList = ProductList.Where(p => p is Models.Pants).ToList();
                    break;
                case 8://Underkläder
                    SortedList = ProductList.Where(p => p is Models.Underwear).ToList();
                    break;
                case 9://Sökrutan - resultat läggs till i sorted list
                    SortedList = new();
                    var nameSearch = ProductList.Where(p => p.Name.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var descriptionSearch = ProductList.Where(p => p.Description.ToLower().Contains(SearchInput.ToLower())).ToList();
                    var colorSearch = ProductList.Where(p => p.Colors.ToString().ToLower().Contains(SearchInput.ToLower())).ToList();
                    SortedList.AddRange(nameSearch);
                    SortedList.AddRange(descriptionSearch);
                    SortedList.AddRange(colorSearch);
                    break;
                case 10://Rea listan
                    SortedList = SalesList;
                    break;
            }
        }
        //Postar object till API för att lägga till i listan
        public static void PostProduct(Product productToPost)
        {
            HttpResponseMessage response; //Svar från API metod
            var httpClient = new HttpClient(); //Ny httpklient
            string serialized = JsonConvert.SerializeObject(productToPost); //Serialiserar inskickat object
            StringContent stringToSend = new StringContent(serialized, Encoding.UTF8, "application/json"); //Konverterar json sträng till stringcontent för att kunna skicka 
            switch (productToPost) //Switch för att välja kategori för att posta till API
            {
                case Underwear:
                    response = httpClient.PostAsync("https://localhost:44397/addunderwear", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Pants:
                    response = httpClient.PostAsync("https://localhost:44397/addpants", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shirts:
                    response = httpClient.PostAsync("https://localhost:44397/addshirts", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shoes:
                    response = httpClient.PostAsync("https://localhost:44397/addshoes", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Jackets:
                    response = httpClient.PostAsync("https://localhost:44397/addjackets", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
            }
        }
        //Editerar objekt i API
        public static void PutProduct(Product productToPut)
        {
            HttpResponseMessage response; //Svar från API metod
            var httpClient = new HttpClient(); //Ny httpklient
            string serialized = JsonConvert.SerializeObject(productToPut); //Serialiserar inskickat object
            StringContent stringToSend = new StringContent(serialized, Encoding.UTF8, "application/json"); //Konverterar json sträng till stringcontent för att kunna skicka 
            switch (productToPut) //Switch för att välja kategori för att posta till API
            {
                case Underwear:
                    response = httpClient.PutAsync("https://localhost:44397/editunderwear", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Pants:
                    response = httpClient.PutAsync("https://localhost:44397/editpants", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shirts:
                    response = httpClient.PutAsync("https://localhost:44397/editshirts", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Shoes:
                    response = httpClient.PutAsync("https://localhost:44397/editshoes", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
                case Jackets:
                    response = httpClient.PutAsync("https://localhost:44397/editjackets", stringToSend).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
                    break;
            }
        }
        public static void DeleteProduct(int productId)
        {
            HttpResponseMessage response; //Svar från API metod
            var httpClient = new HttpClient(); //Ny httpklient
            string Uri = "https://localhost:44397/deleteproduct/";
            Uri += productId.ToString();
            response = httpClient.DeleteAsync(Uri).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode) { AddProductResponse = "Success"; }
        }
        //Hämtar test produktlista från API
        public static List<Product> GetTestProductList()
        {
            var httpClient = new HttpClient();
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var response = httpClient.GetAsync("https://localhost:44397/gettestproducts").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            apiResponse = apiResponse.Replace("WebbshoppenAPI", "Webbshoppen");//Ersätter WebbshoppAPI med webbshopp för att få rätt typ
            var ProductList = JsonConvert.DeserializeObject<List<Product>>(apiResponse, settings);
            UpdateProductId(ProductList);
            return ProductList;
        }
        //Hämtar produktlista från API
        public static List<Product> GetProductList()
        {
            var httpClient = new HttpClient();
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var response = httpClient.GetAsync("https://localhost:44397/getproducts").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            apiResponse = apiResponse.Replace("WebbshoppenAPI", "Webbshoppen");//Ersätter WebbshoppAPI med webbshopp för att få rätt typ
            var ProductList = JsonConvert.DeserializeObject<List<Product>>(apiResponse, settings);
            UpdateProductId(ProductList);
            return ProductList;
        }
        //Lägger till 3 random produkter i realistan
        public static void GetRandomSalesProduct()
        {
            SalesList = new();
            float discount = 100 - Discount;
            discount = discount / 100;
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new();
                var rndInt = rnd.Next(0, ProductList.Count);
                Product temp = new();
                if (ProductList[rndInt] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[rndInt]); }
                if (ProductList[rndInt] is Pants) { temp = Pants.Clone((Pants)ProductList[rndInt]); }
                if (ProductList[rndInt] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[rndInt]); }
                if (ProductList[rndInt] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[rndInt]); }
                if (ProductList[rndInt] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[rndInt]); }
                temp.Price = Math.Round(temp.Price * discount);
                SalesList.Add(temp);
            }
        }
        //Sorterar produktlistan efter ProduktId
        public static void OrderProductList()
        {
            ProductList = ProductList.OrderBy(p => p.ProductId).ToList();
        }
        //Lägger till Reaprodukt i realistan med ett bestämt produktid
        public static void AddSalesProduct(int productId)
        {
            Product temp = new();
            if (ProductList[productId] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[productId]); }
            if (ProductList[productId] is Pants) { temp = Pants.Clone((Pants)ProductList[productId]); }
            if (ProductList[productId] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[productId]); }
            if (ProductList[productId] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[productId]); }
            if (ProductList[productId] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[productId]); }
            SalesList.Add(temp);
        }
        //Updaterar realistans priser om man ändrar discount
        public static void UpdateSalesList()
        {
            float discount = 100 - Discount;
            discount = discount / 100;

            for (int i = 0; i < SalesList.Count; i++)
            {
                Product temp = new();
                int productId = SalesList[i].ProductId;
                SalesList.RemoveAll(p => p.ProductId == productId);
                if (ProductList[productId] is Jackets) { temp = Jackets.Clone((Jackets)ProductList[productId]); }
                if (ProductList[productId] is Pants) { temp = Pants.Clone((Pants)ProductList[productId]); }
                if (ProductList[productId] is Shirts) { temp = Shirts.Clone((Shirts)ProductList[productId]); }
                if (ProductList[productId] is Shoes) { temp = Shoes.Clone((Shoes)ProductList[productId]); }
                if (ProductList[productId] is Underwear) { temp = Underwear.Clone((Underwear)ProductList[productId]); }
                temp.Price = Math.Round(temp.Price * discount);
                SalesList.Add(temp);
            }
        }
    }
}
