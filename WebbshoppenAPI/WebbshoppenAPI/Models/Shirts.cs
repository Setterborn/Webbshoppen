using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbshoppenAPI.Models
{
    public class Shirts : Product
    {
        public int Size { get; set; }
        public Colors Colors { get; set; }
        public Gender Gender { get; set; }

        public Shirts(int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)
        {
            Size = size;
            Colors = color;
            Gender = gender;
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
            ImageLink = imageLink;
        }
    }
}
