using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbshoppenAPI.Models
{
    public class Underwear : Product
    {
        public string Size { get; set; }
       
        public UnderwearSexyness UnderwearSexyness { get; set; }

        public Underwear(int productId, string size, Colors color, Gender gender, string name,double price, string description, int stock, UnderwearSexyness underwearSexyness, string imageLink)
        {
            ProductId = productId;
           
            Size = size;
            Colors = color;
            Gender = gender;
            Name = name;
            
            Price = price;
            Description = description;
            Stock = stock;
            UnderwearSexyness = underwearSexyness;
            ImageLink = imageLink;
        }
    }
}
