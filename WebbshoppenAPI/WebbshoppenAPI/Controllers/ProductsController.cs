using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenAPI.Models;
using WebbshoppenAPI.Data;
using Newtonsoft.Json;

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
