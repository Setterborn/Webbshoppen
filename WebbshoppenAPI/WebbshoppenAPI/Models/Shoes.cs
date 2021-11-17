using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbshoppenAPI.Models
{
    public class Shoes : Product
    {
        public int Size { get; set; }

        public Shoes(int productId, int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)
        {
            ProductId = productId;
            
            Size = size;
            Colors = color;
            Gender = gender;
            Name = name;
          
            Price = price;
           
            Description = description;
            Stock = stock;
            ImageLink = imageLink;
        }
        public Shoes()
        {
        }
    }
}
