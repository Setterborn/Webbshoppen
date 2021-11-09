using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshoppen.Models
{
    public class Underwear : Product
    {
        public int Size { get; set; }
        public Colors Colors { get; set; }
        public Gender Gender { get; set; }
        public UnderwearSexyness UnderwearSexyness { get; set; }

        public Underwear(int size, Colors color, Gender gender, string name, double price, string description, int stock, UnderwearSexyness underwearSexyness, string imageLink)
        {
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
