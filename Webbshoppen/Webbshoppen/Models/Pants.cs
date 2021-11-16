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

        public Pants(int productId, int size, Colors color, Gender gender, string name, double price, string description, int stock,string imageLink)
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
        public static Pants Clone(Pants input)
        {
            var temp = new Pants
            (
                input.ProductId,
                input.Size,
                input.Colors,
                input.Gender,
                input.Name,
                input.Price,
                input.Description,
                input.Stock,
                input.ImageLink
            );
            return temp;
        }
    }
}
