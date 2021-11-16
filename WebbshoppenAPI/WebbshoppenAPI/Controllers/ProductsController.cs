using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using WebbshoppenAPI.Data;
using WebbshoppenAPI.Models;

namespace WebbshoppenAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller // ControllerBase
    {
        [HttpGet]
        public string GetProducts() // Spelar ingen roll vad den heter
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string Serialized = JsonConvert.SerializeObject(ProductManager.GetProducts(), settings);
            return Serialized;
        }
    }

}
