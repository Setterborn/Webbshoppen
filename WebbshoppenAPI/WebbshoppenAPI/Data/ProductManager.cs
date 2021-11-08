﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenAPI.Models;

namespace WebbshoppenAPI.Data
{
    public class ProductManager
    {
        public List<Product> ProductList { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> Products = new();

            //Pants
            // public Pants(int size, Colors color, Gender gender, string name, double price, string description, int stock,string imageLink)

            Products.Add(new Pants(36, Colors.Black, Gender.Male, "Diesel Jeans", 299, "Ett par snygga byuxor", 10, "/link"));
            Products.Add(new Pants(36, Colors.Black, Gender.Male, "Diesel Jeans", 299, "Ett par snygga byuxor", 10, "/link"));
            Products.Add(new Pants(36, Colors.Black, Gender.Male, "Diesel Jeans", 299, "Ett par snygga byuxor", 10, "/link"));
            Products.Add(new Pants(36, Colors.Black, Gender.Male, "Diesel Jeans", 299, "Ett par snygga byuxor", 10, "/link"));

            //Shirts
            // public Shirts(int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)

            Products.Add(new Shirts(42, Colors.Black, Gender.Male, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shirts(42, Colors.Black, Gender.Male, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shirts(42, Colors.Black, Gender.Male, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shirts(42, Colors.Black, Gender.Male, "Vit tröja", 199, "En ful tröja", 10, "/link"));

            //Shoes
            // public Shoes(int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)

            Products.Add(new Shoes(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shoes(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shoes(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, "/link"));
            Products.Add(new Shoes(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, "/link"));

            // Jackets
            // public Jackets(int size, Colors color, Gender gender, string name, double price, string description, int stock, JacketLenght jacketLenght, string imageLink)

            Products.Add(new Jackets(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, JacketLenght.Long, "/link"));
            Products.Add(new Jackets(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, JacketLenght.Long, "/link"));
            Products.Add(new Jackets(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, JacketLenght.Long, "/link"));
            Products.Add(new Jackets(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, JacketLenght.Long, "/link"));

            // Underwear
            // public Underwear(int size, Colors color, Gender gender, string name, double price, string description, int stock, UnderwearSexyness underwearSexyness, string imageLink)

            Products.Add(new Underwear(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, UnderwearSexyness.NotSexy, "/link"));
            Products.Add(new Underwear(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, UnderwearSexyness.NotSexy, "/link"));
            Products.Add(new Underwear(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, UnderwearSexyness.NotSexy, "/link"));
            Products.Add(new Underwear(42, Colors.Black, Gender.Unisex, "Vit tröja", 199, "En ful tröja", 10, UnderwearSexyness.NotSexy, "/link"));

            return Products;
        }
    }
}