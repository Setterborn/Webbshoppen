using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webbshoppen.Models;

namespace Webbshoppen.Models
{
    public class Pants : Product
    {
        public int Size { get; set; }
        public Colors Colors   { get; set; }
        public Gender Gender { get; set; }

        public Pants(int size, Colors color, Gender gender, string name, double price, string description, int stock,string imageLink)
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
