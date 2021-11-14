using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshoppen.Models
{
    public class Jackets : Product
    {
        public int Size { get; set; }
        public JacketLenght JacketLenght { get; set; }

        public Jackets(int productId, int size, Colors color, Gender gender, string name, double price, string description, int stock, JacketLenght jacketLenght, string imageLink)
        {
            ProductId = productId;
            Size = size;
            Colors = color;
            Gender = gender;
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
            JacketLenght = jacketLenght;
            ImageLink= imageLink;
        }
        public static Jackets Clone(Jackets input)
        {
            var temp = new Jackets
            (
                input.ProductId,
                input.Size,
                input.Colors,
                input.Gender,
                input.Name,
                input.Price,
                input.Description,
                input.Stock,
                input.JacketLenght,
                input.ImageLink
            );
            return temp;
        }
    }
}
