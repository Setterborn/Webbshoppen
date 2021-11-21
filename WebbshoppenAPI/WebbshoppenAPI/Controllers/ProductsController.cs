using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebbshoppenAPI.Data;
using WebbshoppenAPI.Models;

namespace WebbshoppenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        //Metod för klienten att hämta test produktkatalog
        [Route("/gettestproducts")]
        [HttpGet]
        public string GetTestProducts()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string Serialized = JsonConvert.SerializeObject(ProductManager.TestProducts, settings);
            return Serialized;
        }
        //Metod för klienten att hämta produktkatalog
        [Route("/getproducts")]
        [HttpGet]
        public string GetProducts()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string Serialized = JsonConvert.SerializeObject(ProductManager.Products, settings);
            return Serialized;
        }
        //Metod för att ta emot och lägga till underkläder i produktkatalog
        [Route("/addunderwear")]
        [HttpPost]
        public IActionResult AddUnderwear([FromBody] Underwear productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till jackor i produktkatalog
        [Route("/addjackets")]
        [HttpPost]
        public IActionResult AddJackets([FromBody] Jackets productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till tröjor i produktkatalog
        [Route("/addshirts")]
        [HttpPost]
        public IActionResult AddShirts([FromBody] Shirts productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till skor i produktkatalog
        [Route("/addshoes")]
        [HttpPost]
        public IActionResult AddShoes([FromBody] Shoes productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till byxor i produktkatalog
        [Route("/addpants")]
        [HttpPost]
        public IActionResult AddPants([FromBody] Pants productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till underkläder i produktkatalog
        [Route("/editunderwear")]
        [HttpPut]
        public IActionResult EditUnderwear([FromBody] Underwear productToAdd)
        {
            ProductManager.Products.RemoveAt(productToAdd.ProductId);
            ProductManager.Products.Insert(productToAdd.ProductId, productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till jackor i produktkatalog
        [Route("/editjackets")]
        [HttpPut]
        public IActionResult EditJackets([FromBody] Jackets productToAdd)
        {
            ProductManager.Products.RemoveAt(productToAdd.ProductId);
            ProductManager.Products.Insert(productToAdd.ProductId, productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till tröjor i produktkatalog
        [Route("/editshirts")]
        [HttpPut]
        public IActionResult EditShirts([FromBody] Shirts productToAdd)
        {
            ProductManager.Products.RemoveAt(productToAdd.ProductId);
            ProductManager.Products.Insert(productToAdd.ProductId, productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till skor i produktkatalog
        [Route("/editshoes")]
        [HttpPut]
        public IActionResult EditShoes([FromBody] Shoes productToAdd)
        {
            ProductManager.Products.RemoveAt(productToAdd.ProductId);
            ProductManager.Products.Insert(productToAdd.ProductId, productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //Metod för att ta emot och lägga till byxor i produktkatalog
        [Route("/editpants")]
        [HttpPut]
        public IActionResult EditPants([FromBody] Pants productToAdd)
        {
            ProductManager.Products.RemoveAt(productToAdd.ProductId);
            ProductManager.Products.Insert(productToAdd.ProductId, productToAdd);
            ProductManager.WriteToFile(ProductManager.Products);
            return Ok();
        }
        //[Route("/deleteproduct")]
        //[HttpDelete("{id}")]
        //public IActionResult DeleteProduct(int id)
        //{
        //    ProductManager.Products.RemoveAt(id);
        //    ProductManager.WriteToFile(ProductManager.Products);
        //    return Ok();
        //}

    }
}
