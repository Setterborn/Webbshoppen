using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenAPI.Models;
using WebbshoppenAPI.Data;

namespace WebbshoppenAPI.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class ProductsController : Controller // ControllerBase
        {
            [HttpGet]
            public List<Product> GetProducts() // Spelar ingen roll vad den heter
            {
                return ProductManager.GetProducts();
            }
        }
    
}
