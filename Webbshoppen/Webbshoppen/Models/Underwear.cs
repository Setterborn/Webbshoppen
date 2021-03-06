using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshoppen.Models
{
    public class Underwear : Product
    {
        public string Size { get; set; }
        public UnderwearSexyness UnderwearSexyness { get; set; }

        public Underwear(int productId, string size, Colors color, Gender gender, string name, double price, string description, int stock, UnderwearSexyness underwearSexyness, string imageLink)
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
        //Metod för att skapa Deepcopy av object
        public static Underwear Clone(Underwear input)
        {
            var temp = new Underwear
            (
                input.ProductId,
                input.Size,
                input.Colors,
                input.Gender,
                input.Name,
                input.Price,
                input.Description,
                input.Stock,
                input.UnderwearSexyness,
                input.ImageLink
            );
            return temp;
        }
    }
}
