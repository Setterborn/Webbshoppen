using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshoppen.Models
{
    public class Shirts : Product
    {
        public string Size { get; set; }

        public Shirts(int productId, string size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)
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
        //Metod för att skapa Deepcopy av object
        public static Shirts Clone(Shirts input)
        {
            var temp = new Shirts
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
