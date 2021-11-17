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
        [Route("/getproducts")]
        [HttpGet]
        public string GetProducts()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string Serialized = JsonConvert.SerializeObject(ProductManager.Products, settings);
            return Serialized;
        }
        [Route("/addunderwear")]
        [HttpPost]
        public IActionResult AddUnderwear([FromBody] Underwear productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(productToAdd);
            return Ok();
        }
        [Route("/addjackets")]
        [HttpPost]
        public IActionResult AddJackets([FromBody] Jackets productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(productToAdd);
            return Ok();
        }
        [Route("/addshirts")]
        [HttpPost]
        public IActionResult AddShirts([FromBody] Shirts productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(productToAdd);
            return Ok();
        }
        [Route("/addshoes")]
        [HttpPost]
        public IActionResult AddShoes([FromBody] Shoes productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(productToAdd);
            return Ok();
        }
        [Route("/addpants")]
        [HttpPost]
        public IActionResult AddPants([FromBody] Pants productToAdd)
        {
            ProductManager.Products.Add(productToAdd);
            ProductManager.WriteToFile(productToAdd);
            return Ok();
        }
    }

}
