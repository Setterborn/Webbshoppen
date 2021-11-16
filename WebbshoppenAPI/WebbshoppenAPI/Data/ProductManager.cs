using System;
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
            // public Pants(index number,int size, Colors color, Gender gender, string name, double price,string type, string description, int stock,string imageLink)
            //Male Pants list
            //1-darkblue jeans normal
            Products.Add(new Pants(0,26, Colors.DarkBlue, Gender.Male, "Normal Fit Darkblue Jeans,Weekday", 599.90, "Normal fit jeans with a tapered leg and low rise.Pocket style with a modern look.Button fly.", 10, "fashion-g35b8f02e0_640.jpg"));
            Products.Add(new Pants(1,27, Colors.DarkBlue, Gender.Male, "Normal Fit Darkblue Jeans,Weekday", 599.90, "Normal fit jeans with a tapered leg and low rise.Pocket style with a modern look.Button fly.", 25, "fashion-g35b8f02e0_640.jpg"));
            Products.Add(new Pants(2,28, Colors.DarkBlue, Gender.Male, "Normal Fit Darkblue Jeans,Weekday", 599.90, "Normal fit jeans with a tapered leg and low rise.Pocket style with a modern look.Button fly.", 12, "fashion-g35b8f02e0_640.jpg"));
            Products.Add(new Pants(3,26, Colors.DarkBlue, Gender.Male, "Normal Fit Darkblue Jeans,Weekday", 599.90, "Normal fit jeans with a tapered leg and low rise.Pocket style with a modern look.Button fly.", 19, "fashion-g35b8f02e0_640.jpg"));
            Products.Add(new Pants(4,27, Colors.DarkBlue, Gender.Male, "Normal Fit Darkblue Jeans,Weekday", 599.90, "Normal fit jeans with a tapered leg and low rise.Pocket style with a modern look.Button fly.", 5, "fashion-g35b8f02e0_640.jpg"));
            //2-greyblue jeans 
            Products.Add(new Pants(5,26, Colors.Greyblue, Gender.Male, "Slim Fit Grey blue Jeans,Weekday", 699.90, "Slim fit jeans with a low rise.Zip fly and button closer.Pockets on the side and back.", 10, "pants-gbcde4907a_640.jpg"));
            Products.Add(new Pants(6,28, Colors.Greyblue, Gender.Male, "Slim Fit Grey blue Jeans,Weekday", 699.90, "Slim fit jeans with a low rise.Zip fly and button closer.Pockets on the side and back.", 17, "pants-gbcde4907a_640.jpg"));
            Products.Add(new Pants(7,29, Colors.Greyblue, Gender.Male, "Slim Fit Greyblue Jeans,Weekday", 699.90, "Slim fit jeans with a low rise.Zip fly and button closer.Pockets on the side and back.", 10, "pants-gbcde4907a_640.jpg"));
            Products.Add(new Pants(8,30, Colors.Greyblue, Gender.Male, "Slim Fit Greyblue Jeans,Weekday", 699.90, "Slim fit jeans with a low rise.Zip fly and button closer.Pockets on the side and back.", 7, "pants-gbcde4907a_640.jpg"));
            //3-brown pants normal
            Products.Add(new Pants(9,  26, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise .Zip fly and button closer.Pockets on the side and back. ",13,"male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(10, 27, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 26, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(11, 28, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 13, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(12, 29, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and botton closer.Pockets on the side and back.", 27, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(13, 30, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 26, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(14, 31, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 30, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(15, 32, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 37, "male-gf7eebde49_640.jpg"));
            Products.Add(new Pants(16, 33, Colors.Brown, Gender.Male, "Eli Brown Pants,Acne", 449.90, "Normal fit cottonpants with a normal rise.Zip fly and button closer.Pockets on the side and back.", 23, "male-gf7eebde49_640.jpg"));
            //4-white jeans slim
            
            Products.Add(new Pants(17, 28, Colors.White, Gender.Male, "White Winter Jeans,Acne", 899.90, "Slim fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 3, "pants-g5ecafe282_640.jpg"));
            Products.Add(new Pants(18, 29, Colors.White, Gender.Male, " White Winter Jeans,Acne", 899.90, "Slim fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 12, "pants-g5ecafe282_640.jpg"));
            Products.Add(new Pants(19, 30, Colors.White, Gender.Male, "White Winter Jeans,Acne", 899.90, "Slim fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 21, "pants-g5ecafe282_640.jpg"));
            Products.Add(new Pants(20, 31, Colors.White, Gender.Male, "White Winter Jeans,Acne", 899.90, "Slim fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 21, "pants-g5ecafe282_640.jpg"));
            Products.Add(new Pants(21, 32, Colors.White, Gender.Male, " White Winter Jeans,Acne", 899.90, "Slim fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 21, "pants-g5ecafe282_640.jpg"));
            //5-blue jeans normal
            Products.Add(new Pants(22, 28, Colors.Blue, Gender.Male, "The Edition:Normal Fit Pants,Diesel", 949.90, "Normal fit pants with a normal rise.Button and zipfly.Pockets on the side and back.", 2, "pants-g4ddffe9a1_640.jpg"));
            Products.Add(new Pants(23, 29, Colors.Blue, Gender.Male, "The Edition:Normal Fit Pants,Diesel", 949.90, "Normal fit pants with a normal rise.Button and zipfly.Pockets on the side and back.", 10, "pants-g4ddffe9a1_640.jpg"));
            Products.Add(new Pants(24, 31, Colors.Blue, Gender.Male, "The Edition:Normal Fit Pants,Diesel", 949.90, "Normal fit pants with a normal rise.Button and zipfly.Pockets on the side and back.", 15, "pants-g4ddffe9a1_640.jpg"));
            Products.Add(new Pants(25, 32, Colors.Blue, Gender.Male, "The Edition:Normal Fit Pants,Diesel", 949.90, "Normal fit jeans with a normal rise.Button and zipfly.Pockets on the side and back.", 15, "pants-g4ddffe9a1_640.jpg"));
            //6- grey jeans normal
            Products.Add(new Pants(26, 28, Colors.Grey, Gender.Male, "Casual Fit Grey Jeans,Acne", 449.00, "Normal fit jeans with a mormal rise.Zip fly.Pockets on the side and back.", 10, "male-g1dcdff6df_640.jpg"));
            Products.Add(new Pants(27, 29, Colors.Grey, Gender.Male, "Casual Fit Grey Jeans,Acne", 449.00, "Normal fit jeans with a normal rise.Zip fly.Pockets on the side and back.", 3, "male-g1dcdff6df_640.jpg"));
            Products.Add(new Pants(28, 30, Colors.Grey, Gender.Male, "Casual Fit Grey Jeans,Acne", 449.00, "Normal fit jeans with a normal rise.Zip fly.Pockets on the side and back.", 20, "male-g1dcdff6df_640.jpg"));
            Products.Add(new Pants(29, 31, Colors.Grey, Gender.Male, "Casual Fit Grey Jeans,Acne", 449.00, "Normal fit jeans with a normal rise.Zip fly.Pockets on the side and back.", 20, "male-g1dcdff6df_640.jpg"));
            Products.Add(new Pants(30, 32, Colors.Grey, Gender.Male, "Casual Fit Grey Jeans,Acne", 449.00, "Normal fit jeans with a normal rise.Zip fly.Pockets on the side and back.", 20, "male-g1dcdff6df_640.jpg"));
            //7-black jeans slim
            Products.Add(new Pants(31, 28, Colors.Black, Gender.Male, "Normal Fit Jeans Black,Levi", 999.90, "Normal fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 30, "pants-g6b79b0d74_640.jpg"));
            Products.Add(new Pants(32, 29, Colors.Black, Gender.Male, "Normal Fit Jeans Black ,Levi",999.90, "Normal fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 25, "pants-g6b79b0d74_640.jpg"));
            Products.Add(new Pants(33, 30, Colors.Black, Gender.Male, "Normal Fit Jeans Black,Levi", 999.90, "Normal fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 20, "pants-g6b79b0d74_640.jpg"));
            Products.Add(new Pants(34, 31, Colors.Black, Gender.Male, "Normal Fit Jeans Black,Levi", 999.90, "Normal fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 20, "pants-g6b79b0d74_640.jpg"));
            Products.Add(new Pants(35, 32, Colors.Black, Gender.Male, "Normal Fit Jeans Black,Levi", 999.90, "Normal fit jeans with a normal rise.Zip fly and button closer.Pockets on the side and back.", 20, "pants-g6b79b0d74_640.jpg"));


            //Woman pants list
            //1-green pants
            Products.Add(new Pants(36, 36, Colors.Green, Gender.Female, "Slimy Fit Pants Mitty,Levi", 799.00, "Slim elastic fit pants with a low rise.Zip fly and button closer.Pockets on the side and back.", 10, "girl-g72e6d6e63_640.jpg"));
            Products.Add(new Pants(37, 38, Colors.Green, Gender.Female, "Slimy Fit Pants Mitty,Levi",799.00, "Slim elastic fit pants with a low rise.Zip fly and button closer.Pockets on the side and back.", 11, "girl-g72e6d6e63_640.jpg"));
            Products.Add(new Pants(38, 40, Colors.Green, Gender.Female, "Slimy Fit Pants Mitty,Levi", 799.00, "Slim elastic fit pants with a low rise.Zip fly and button closer.Pockets on the side and back.", 20, "girl-g72e6d6e63_640.jpg"));
            Products.Add(new Pants(39, 42, Colors.Green, Gender.Female, "Slimy Fit Pants Mitty,Levi", 799.00, "Slim elastic fit pants with a low rise.Zip fly and button closer.Pockets on the side and back.", 18, "girl-g72e6d6e63_640.jpg"));
            Products.Add(new Pants(40, 44, Colors.Green, Gender.Female, "Slimy Fit Pants Mitty,Levi", 799.00, "Slim elastic fit pants with a low rise.Zip fly and button closer.Pockets on the side and back.", 18, "girl-g72e6d6e63_640.jpg"));
            //2-ript slim jeans
            Products.Add(new Pants(41, 36, Colors.Blue, Gender.Female, " Jeans Ript Slim,Diesel", 1050.90, "Slim fit jeans with a low rise.Ript on the leg.Zip fly and button closer.Pockets on the side and back.", 5, "blue-g21016255e_640.jpg"));
            Products.Add(new Pants(42, 38, Colors.Blue, Gender.Female, "Jeans Ript Slim,Diesel", 1050.90, "Slim fit jeans with a low rise.Ript on the leg.Zip fly and button closer.Pockets on the side and back.", 11, "blue-g21016255e_640.jpg"));
            Products.Add(new Pants(43,40, Colors.Blue, Gender.Female, "Jeans Ript Slim,Diesel", 1050.90, "Slim fit jeans with a low rise.Ript on the leg.Zip fly and button closer.Pockets on the side and back.", 10, "blue-g21016255e_640.jpg"));
            Products.Add(new Pants(44,42, Colors.Blue, Gender.Female, "Jeans Ript Slim,Diesel", 1050.90, "Slim fit jeans with a low rise.Ript on the leg.Zip fly and button closer.Pockets on the side and back.", 18, "blue-g21016255e_640.jpg"));
            Products.Add(new Pants(45,44, Colors.Blue, Gender.Female, "Jeans Ript Slim,Diesel", 1050.90, "Slim fit jeans with a low rise.Ript on the leg.Zip fly and button closer.Pockets on the side and back.", 18, "blue-g21016255e_640.jpg"));
            //3-yellow pants
            Products.Add(new Pants(46, 36, Colors.Yellow, Gender.Female, "Yellow Mustard Kitty Pants,Weekday", 699.90, "Low rise cotton pants with button and zipfly.Pockets on the side and back.", 2, "brunette-g92217d997_640.jpg"));
            Products.Add(new Pants(47, 38, Colors.Yellow, Gender.Female, "Yellow Mustad Kitty Pants,Weekday", 699.90, "Low rise cotton pants with button and zipfly.Pockets on the side and back.", 0, "brunette-g92217d997_640.jpg"));
            Products.Add(new Pants(48, 40, Colors.Yellow, Gender.Female, "Yellow Mustard Kitty Pants,Weekday", 699.90, "Low rise cotton pants with button and zipfly.Pockets on the side and back.", 8, "brunette-g92217d997_640.jpg"));
            Products.Add(new Pants(49, 42, Colors.Yellow, Gender.Female, "Yellow Mustard Kitty Pants,Weekday", 699.90, "Low rise cotton pants with button and zipfly.Pockets on the side and back.", 10, "brunette-g92217d997_640.jpg"));
            Products.Add(new Pants(50, 44, Colors.Yellow, Gender.Female, "Yellow Mustard Kitty Pants,Weekday", 699.90, "Low rise cotton pants with button and zipfly.Pockets on the side and back.", 8, "brunette-g92217d997_640.jpg"));
            //4-baggy jeans pants
            Products.Add(new Pants(51, 36, Colors.Lightblue, Gender.Female, "Loose Jeans LuAnn,Monkey", 399.90, "Loose jeans with a high rise.Button and zipfly.Elastic band around the ankle", 2, "denim-g6eeb2ee8f_640.jpg"));
            Products.Add(new Pants(52, 38, Colors.Lightblue, Gender.Female, "Loose Jeans LuAnn,Monkey", 399.90, "Loose jeans with a high rise.Button and zipfly.Elastic band around the ankle ", 0, "denim-g6eeb2ee8f_640.jpg"));
            Products.Add(new Pants(53, 40, Colors.Lightblue, Gender.Female, "Loose Jeans LuAnn,Monkey", 399.90, "Loose jeans with a high rise.Button and zipfly.Elastic band around the ankle", 8, "denim-g6eeb2ee8f_640.jpg"));
            Products.Add(new Pants(54, 42, Colors.Lightblue, Gender.Female, "Loose Jeans LuAnn,Monkey", 399.90, "Loose jeans  with a high rise.Button and zipfly.Elastic band around the ankle", 10, "denim-g6eeb2ee8f_640.jpg"));
            Products.Add(new Pants(55, 44, Colors.Lightblue, Gender.Female, "Loose Jeans LuAnn,Monkey", 399.90, "Loose jeans with a high rise.Button and zipfly.Elastic band around the ankle", 8, "denim-g6eeb2ee8f_640.jpg"));
            //5-black suit pants
            Products.Add(new Pants(56,36, Colors.Black, Gender.Female, "Black Suit Pants,Monkey", 749.90, "Slim suit pants with high rise and short legs.Side pockets.Button and zipfly", 32, "clothes-gdb337a5dd_640.jpg"));
            Products.Add(new Pants(57,38, Colors.Black, Gender.Female, "Black Suit Pants,Monkey", 749.90, "Slim suit pants with high rise and short legs.Side pockets.Button and zipfly ", 25, "clothes-gdb337a5dd_640.jpg"));
            Products.Add(new Pants(58,40, Colors.Black, Gender.Female, "Black Suit Pants,Monkey", 749.90, "Slim suit pants with high rise and short legs.Side pockets.Button and zipfly", 25, "clothes-gdb337a5dd_640.jpg"));
            Products.Add(new Pants(59,42, Colors.Black, Gender.Female, " Black Suit Pants,Monkey", 749.90, "Slim suit pants with high rise and short legs.Side pockets.Button and zipfly", 18, "clothes-gdb337a5dd_640.jpg"));
            Products.Add(new Pants(60,44, Colors.Black, Gender.Female, "Black Suit Pants,Monkey", 749.90, "Slim suit pants with high rise and short legs.Side pockets.Button and zipfly", 15, "clothes-gdb337a5dd_640.jpg"));
            //6-black/white printed pants
            Products.Add(new Pants(61, 34, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 15, "hat-g1540c65a1_640.jpg"));
            Products.Add(new Pants(62, 34, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 15, "hat-g1540c65a1_640.jpg"));
            Products.Add(new Pants(63, 36, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 0, "hat-g1540c65a1_640.jpg"));
            Products.Add(new Pants(64, 38, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 26, "hat-g1540c65a1_640.jpg"));
            Products.Add(new Pants(65, 40, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 14, "hat-g1540c65a1_640.jpg"));
            Products.Add(new Pants(66, 42, Colors.PrintedColor, Gender.Female, "Black and White Printed Flare Pants,Monkey", 1199.00, "A pair of full-length black and white printed trousers in woven quality with wide legs. The trousers have a high waist with hidden elastic and folds and a hidden zipper on one side. Slanted side pockets and cheat pockets at the back.", 10 , "hat-g1540c65a1_640.jpg"));







            //Shirts
            // public Shirts(int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)
            //Male shirt list
            //1-black print t-shirt
            Products.Add(new Shirts(67, "XSmall", Colors.Black, Gender.Male, "White Printed Black T-shirt,Colmine", 499.90, "Black T-shirt with white print.Material:Cotton", 14, "man-g6fe9bfe2f_640.jpg"));
            Products.Add(new Shirts(68, "Small", Colors.Black, Gender.Male, "White Printed Black T-shirt,Colmine", 499.90, "Black T -shirt with white print.Material:Cotton", 20, "man-g6fe9bfe2f_640.jpg"));
            Products.Add(new Shirts(69, "Medium", Colors.Black, Gender.Male, "White Printed Black T-shirt,Colmine", 499.90, "Black T -shirt with white print.Material:Cotton",25, "man-g6fe9bfe2f_640.jpg"));
            Products.Add(new Shirts(70, "Large", Colors.Black, Gender.Male, "White Printed Black T-shirt ,Colmine", 499.90, "Black T -shirt with white print.Material:Cotton", 10, "man-g6fe9bfe2f_640.jpg"));
            Products.Add(new Shirts(71, "XLarge", Colors.Black, Gender.Male, "White Printed Black T-shirt,Colmine", 499.90, " Black T -shirt with white print.Material:Cotton", 3, "man-g6fe9bfe2f_640.jpg"));
            Products.Add(new Shirts(72, "XXLarge", Colors.Black, Gender.Male, "White Printed Black T-shirt,Colmine", 499.90, "Black T -shirt with white print .Material:Cotton", 7, "man-g6fe9bfe2f_640.jpg"));

           //2-red cotton shirt
            Products.Add(new Shirts(73, "XSmall", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 10, "shirt-gc730aba1e_640.jpg"));
            Products.Add(new Shirts(74, "Small", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 1, "shirt-gc730aba1e_640.jpg"));
            Products.Add(new Shirts(75, "Medium", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 12, "shirt-gc730aba1e_640.jpg"));
            Products.Add(new Shirts(76, "Large", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 18, "shirt-gc730aba1e_640.jpg"));
            Products.Add(new Shirts(77, "XLarge", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 10, "shirt-gc730aba1e_640.jpg"));
            Products.Add(new Shirts(78, "XXLarge", Colors.Red, Gender.Male, "Toby Red Cotton Shirt,Comfort", 699.90, "Classical red shirt with long sleeve.Button down collar and button tie on arm.Material:Cottonmix", 9, "shirt-gc730aba1e_640.jpg"));

            //3-white shirt
            Products.Add(new Shirts(79, "XSmall", Colors.White, Gender.Male, "Luca White Shirt,Acne", 799.90, "A shirt in stretchy cotton oxford with folds.Lond sleeve.Button down collar.Material:stretch cotton", 14, "man-gd61bf1f0f_640.jpg")); 
            Products.Add(new Shirts(80, "Medium", Colors.White, Gender.Male, "Luca White Shirt,Acne", 799.90, "A shirt in stretchy cotton oxford with folds.Lond sleeve.Button down collar.Material:stretch cotton", 20, "man-gd61bf1f0f_640.jpg"));
            Products.Add(new Shirts(81, "Large", Colors.White, Gender.Male, "Luca White Shirt,Acne", 799.90, "A shirt in stretchy cotton oxford with folds.Lond sleeve.Button down collar.Material:stretch cotton", 19, "man-gd61bf1f0f_640.jpg"));
            Products.Add(new Shirts(82, "XLarge", Colors.White, Gender.Male, "Luca White Shirt,Acne", 799.90, "A shirt in stretchy cotton oxford with folds.Lond sleeve.Button down collar.Material:stretch cotton", 17, "man-gd61bf1f0f_640.jpg"));
            Products.Add(new Shirts(83, "XXLarge", Colors.White, Gender.Male, "Luca White Shirt,Acne", 799.90, "A shirt in stretchy cotton oxford with folds.Lond sleeve.Button down collar.Material:stretch cotton", 11, "man-gd61bf1f0f_640.jpg"));
            //4-blue shirt
            Products.Add(new Shirts(84,"XSmall", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt.The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 8, "man-gd9002da51_640.jpg"));
            Products.Add(new Shirts(85, "Small", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt.The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 10, "man-gd9002da51_640.jpg"));
            Products.Add(new Shirts(86, "Medium", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt.The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 16, "man-gd9002da51_640.jpg"));
            Products.Add(new Shirts(87, "Large", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt .The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 13, "man-gd9002da51_640.jpg"));
            Products.Add(new Shirts(88, "XLarge", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt.The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 10, "man-gd9002da51_640.jpg"));
            Products.Add(new Shirts(89, "XXLarge", Colors.DarkBlue, Gender.Male, "Jona Darkblue Shirt,Acne", 1899.90, "Darkblue casual fit cotton shirt.The shirt has a button-down collar and a classic button-down. Long sleeves and cuff with adjustable buttoning.", 14, "man-gd9002da51_640.jpg"));
            //5-jeans shirt
            Products.Add(new Shirts(90, "XSmall", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, "Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 14, "man-g9f23d13f0_640.jpg"));
            Products.Add(new Shirts(91, "Small", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, "Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 10, "man-g9f23d13f0_640.jpg"));
            Products.Add(new Shirts(92, "Medium", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, "Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 9, "man-g9f23d13f0_640.jpg"));
            Products.Add(new Shirts(93, "Large", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, "Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 16, "man-g9f23d13f0_640.jpg"));
            Products.Add(new Shirts(94, "XLarge", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, " Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 10, "man-g9f23d13f0_640.jpg"));
            Products.Add(new Shirts(95, "XXLarge", Colors.Lightblue, Gender.Male, "Casual Jeans Shirt,Acne", 499.90, " Causual fit jeans shirt with buttons. Long sleeve.Down button collar.Chest pocket.Material:jeans", 3, "man-g9f23d13f0_640.jpg"));
            //- red Tshirt/unisex
            Products.Add(new Shirts(96, "Small", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(97, "Small", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 45, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(98, "Medium", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T -shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 42, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(99, "Large", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 39, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(100, "XLarge", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 38, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(101, "XXLarge", Colors.Red, Gender.Male, "Red Basic T -shirt,Coldmine", 399.00, "Basic red T -shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g98185192b_640.png"));
            //-blue T-shirt/unisex
            Products.Add(new Shirts(102, "XSmall", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 36, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(103, "Small", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(104, "Medium", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 13, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(105, "Large", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 42, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(106, "XLarge", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 33, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(107, "XXLarge", Colors.Blue, Gender.Male, "Blue Basic T-shirt,Coldmine", 399.00, "Basic blue T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 30, "blank-g6ac585d02_640.png"));


            //-white t- shirt/unisex
            Products.Add(new Shirts(108, "XSmall", Colors.White, Gender.Male, "White Basic T-shirt,Coldmine", 399.00, "Basic white T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 26, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(109, "Small", Colors.White, Gender.Male, "White Basic T-shirt,Coldmine", 399.00, "Basic white T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 31, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(110, "Medium", Colors.White, Gender.Male, "White Basic T-shirt,Coldmine", 399.00, "Basic white T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 29, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(111, "Large", Colors.White, Gender.Male, "White Basic T-shirt,Coldmine", 399.00, "Basic white T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(112, "XLarge", Colors.White, Gender.Male, "White Basic T-shirt,Coldmine", 399.00, "Basic white T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 27, "blank-g57474815a_640.png"));
            //-black t shirt/unisex
            Products.Add(new Shirts(113, "XSmall", Colors.Black, Gender.Male, "Black Basic T-shirt,Coldmine", 399.00, "Basic black T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 19, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(114, "Small", Colors.Black, Gender.Male, "Black Basic T-shirt,Coldmine", 399.00, "Basic black T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 18, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(115, "Medium", Colors.Black, Gender.Male, "Black Basic T-shirt,Coldmine", 399.00, "Basic black T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 2, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(116, "Large", Colors.Black, Gender.Male, "Black Basic T-shirt,Coldmine", 399.00, "Basic black  T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 11, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(117, "XLarge", Colors.Black, Gender.Male, "Black Basic T-shirt,Coldmine", 399.00, "Basic black T-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 10, "blank-gaefa30c39_640.png"));


            //Female shirts

            //1-blue long sleeve top shirt
            Products.Add(new Shirts(118, "XSmall", Colors.Blue, Gender.Female, "Blue Basic Top V-neck Admin", 199.00, "Blue Basic V- neck top.Long sleeve.Material:Elastic Cotton", 12, "fashion-g22bfb528f_640.jpg"));
            Products.Add(new Shirts(119, "Small", Colors.Blue, Gender.Female, "Blue Basic Top V-neck ,Admin", 199.00, "Blue Basic V- neck top.Long sleeve.Material:Elastic Cotton", 17, "fashion-g22bfb528f_640.jpg"));
            Products.Add(new Shirts(120, "Medium", Colors.Blue, Gender.Female, "Blue Basic Top V-neck ,Admin", 199.00, "Blue Basic V- neck top.Long sleeve. Material:Elastic Cotton", 22, "fashion-g22bfb528f_640.jpg"));
            Products.Add(new Shirts(121, "Large", Colors.Blue, Gender.Female, "Blue Basic Top V-neck ,Admin", 199.00, "Blue Basic V- neck top.Long sleeve. Material:Elastic Cotton", 21, "fashion-g22bfb528f_640.jpg"));
            Products.Add(new Shirts(122, "XLarge", Colors.Blue, Gender.Female, "Blue Basic Top V-neck ,Admin", 199.00, "Blue Basic V- neck top.Long sleeve. Material:Elastic Cotton", 13, "fashion-g22bfb528f_640.jpg"));
            Products.Add(new Shirts(123, "XXLarge", Colors.Blue, Gender.Female, "Blue Basic Top V-neck ,Admin", 199.00, "Blue Basic V- neck top.Long sleeve. Material:Elastic Cotton", 16, "fashion-g22bfb528f_640.jpg"));
            //2-orange long sleeve top shirt
            Products.Add(new Shirts(124, "XSmall", Colors.Orange, Gender.Female, "Orange Basic Top ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 30, "fashion-gf5c9877f4_640.jpg"));
            Products.Add(new Shirts(125, "Small", Colors.Orange, Gender.Female, "Orange Basic Top ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 36, "fashion-gf5c9877f4_640.jpg"));
            Products.Add(new Shirts(126, "Medium", Colors.Orange, Gender.Female, "Orange Basic Topn ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 28, "fashion-gf5c9877f4_640.jpg"));
            Products.Add(new Shirts(127, "Large", Colors.Orange, Gender.Female, "Orange Basic Top ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 24 , "fashion-gf5c9877f4_640.jpg"));
            Products.Add(new Shirts(128, "XLarge", Colors.Orange, Gender.Female, "Orange Basic Top ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 20, "fashion-gf5c9877f4_640.jpg"));
            Products.Add(new Shirts(129, "XXLarge", Colors.Orange, Gender.Female, "Orange Basic Top ,Admin", 199.00, "Orange Basic top.Long sleeve.Round neck. Material:Elastic Cotton", 15, "fashion-gf5c9877f4_640.jpg"));
            //3-white T-shirt with print 
            Products.Add(new Shirts(130, "XSmall", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 16, "jeans-g7dd3e0c3c_640.jpg"));
            Products.Add(new Shirts(131, "Small", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 10, "jeans-g7dd3e0c3c_640.jpg"));
            Products.Add(new Shirts(132, "Medium", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 11, "jeans-g7dd3e0c3c_640.jpg"));
            Products.Add(new Shirts(133, "Large", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 21, "jeans-g7dd3e0c3c_640.jpg"));
            Products.Add(new Shirts(134, "XLarge", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 4, "jeans-g7dd3e0c3c_640.jpg"));
            Products.Add(new Shirts(135, "XXLarge", Colors.White, Gender.Female, "White T-shirt with print ,Admin", 299.00, "White basic t-shirt with print.Round neck.Short sleeve.Material:cotton", 2, "jeans-g7dd3e0c3c_640.jpg"));
            //4-black top long sleeve
            Products.Add(new Shirts(136, "XSmall", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve.Material:Elastic Cotton", 8, "sweater-g026d5994e_640.jpg"));
            Products.Add(new Shirts(137, "Small", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve.Material:Elastic Cotton", 10, "sweater-g026d5994e_640.jpg"));
            Products.Add(new Shirts(138, "Medium", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve. Material:Elastic Cotton", 13, "sweater-g026d5994e_640.jpg"));
            Products.Add(new Shirts(139, "Large", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve.Material:Elastic Cotton", 17, "sweater-g026d5994e_640.jpg"));
            Products.Add(new Shirts(140, "XLarge", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve.Material:Elastic Cotton", 35, "sweater-g026d5994e_640.jpg"));
            Products.Add(new Shirts(141, "XXLarge", Colors.Black, Gender.Female, "Black Top V-neck ,Admin", 199.00, "Black Basic top with V-neck.Long sleeve.Material:Elastic Cotton", 24, "sweater-g026d5994e_640.jpg")); ; ;
            //5-short red blouse shirt
            Products.Add(new Shirts(142, "XSmall", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton",35, "youth-g667037af9_640.jpg"));
            Products.Add(new Shirts(143, "Small", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton", 40, "youth-g667037af9_640.jpg"));
            Products.Add(new Shirts(144, "Medium", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton", 27, "youth-g667037af9_640.jpg"));
            Products.Add(new Shirts(145, "Large", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton", 37, "youth-g667037af9_640.jpg"));
            Products.Add(new Shirts(146, "XLarge", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton", 32, "youth-g667037af9_640.jpg"));
            Products.Add(new Shirts(147, "XXLarge", Colors.Red, Gender.Female, "Red Ella Bluse shirt ,Admin", 399.00, "Red short bluse shirt.Short sleeve.V-veck front and back around the neck.Material:cotton", 30, "youth-g667037af9_640.jpg"));



            //red T-shirt/unisex
            Products.Add(new Shirts(148, "Small", Colors.Red, Gender.Female, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(149, "Small", Colors.Red, Gender.Female, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 45, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(150, "Medium", Colors.Red, Gender.Female, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 42, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(151, "Large", Colors.Red, Gender.Female, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 39, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(152, "XLarge", Colors.Red, Gender.Female, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 38, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(153, "XXLarge", Colors.Red, Gender.Female, "Red Basic T -shirt,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g98185192b_640.png"));
            //-blue t shirt/unisex
            Products.Add(new Shirts(154, "XSmall", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 36, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(155, "Small", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(156, "Medium", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 13, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(157, "Large", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 42, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(158, "XLarge", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 33, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(159, "XXLarge", Colors.Blue, Gender.Female, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 30, "blank-g6ac585d02_640.png"));


            //-white t- shirt/unisex
            Products.Add(new Shirts(160, "XSmall", Colors.White, Gender.Female, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 26, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(161, "Small", Colors.White, Gender.Female, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 31, "blank-g57474815a_640,png"));
            Products.Add(new Shirts(162, "Medium", Colors.White, Gender.Female, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 29, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(163, "Large", Colors.White, Gender.Female, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(164, "XLarge", Colors.White, Gender.Female, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 27, "blank-g57474815a_640.png"));
            //-black t shirt/unisex
            Products.Add(new Shirts(165, "XSmall", Colors.Black, Gender.Female, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 19, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(166, "Small", Colors.Black, Gender.Female, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 18, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(167, "Medium", Colors.Black, Gender.Female, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 2, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(168, "Large", Colors.Black, Gender.Female, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 11, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(169, "XLarge", Colors.Black, Gender.Female, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 10, "blank-gaefa30c39_640.png"));


            //unisex shirts


            //-red t-shirt
            Products.Add(new Shirts(170, "Small", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00 , "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(171, "Small", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00 , "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 45, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(172, "Medium", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00 , "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 42, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(173, "Large", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 39, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(174, "XLarge", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 38, "blank-g98185192b_640.png"));
            Products.Add(new Shirts(175, "XXLarge", Colors.Red, Gender.Unisex, "Red Basic T -shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g98185192b_640.png"));
            //-blue t shirt
            Products.Add(new Shirts(176, "XSmall", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 36, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(177, "Small", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 40, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(178, "Medium", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 13, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(179, "Large", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton",42, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(180, "XLarge", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 33, "blank-g6ac585d02_640.png"));
            Products.Add(new Shirts(181, "XXLarge", Colors.Blue, Gender.Unisex, "Blue Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 30, "blank-g6ac585d02_640.png"));


            //-white t- shirt
            Products.Add(new Shirts(182, "XSmall", Colors.White, Gender.Unisex, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 26, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(183, "Small", Colors.White, Gender.Unisex, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 31, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(184, "Medium", Colors.White, Gender.Unisex, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 29, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(185, "Large", Colors.White, Gender.Unisex, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 35, "blank-g57474815a_640.png"));
            Products.Add(new Shirts(186, "XLarge", Colors.White, Gender.Unisex, "White Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 27, "blank-g57474815a_640.png"));
            //-black t shirt
            Products.Add(new Shirts(187, "XSmall", Colors.Black, Gender.Unisex, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 19, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(188, "Small", Colors.Black, Gender.Unisex, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 18, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(189, "Medium", Colors.Black, Gender.Unisex, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 2, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(190, "Large", Colors.Black, Gender.Unisex, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 11, "blank-gaefa30c39_640.png"));
            Products.Add(new Shirts(191, "XLarge", Colors.Black, Gender.Unisex, "Black Basic T-shirt ,Coldmine", 399.00, "Basic t-shirt.Short sleeve and round neck.Regular fit.Material:Cotton", 10, "blank-gaefa30c39_640.png"));
            
            







            // Male Shoe list
            // public Shoes(int size, Colors color, Gender gender, string name, double price, string description, int stock, string imageLink)
            //**********
            Products.Add(new Shoes(192,41, Colors.Blue, Gender.Male, " Blue Speed Sneakers ,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 2, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(193,42, Colors.Blue, Gender.Male, "Blue Speed Sneakers ,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 5, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(194,43, Colors.Blue, Gender.Male, " Blue Speed Sneakers ,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 15, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(195,44, Colors.Blue, Gender.Male, "Blue Speed Sneakers ,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 4, "shoes-g28b7de332_640.jpg"));
            //*******
            Products.Add(new Shoes(196, 41, Colors.Red, Gender.Male, "Playing with fire Sneaker ,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 50, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(197, 42, Colors.Red, Gender.Male, "Playing with fire Sneaker ,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 39, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(198, 43, Colors.Red, Gender.Male, "Playing with fire Sneaker ,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 40, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(199, 44, Colors.Red, Gender.Male, "Playing with fire Sneaker ,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 41, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(200, 45, Colors.Red, Gender.Male, "Playing with fire Sneaker ,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 35, "shoes-ge69f3f2f1_640.jpg"));
            //3-low black leather shoe
            Products.Add(new Shoes(201, 41, Colors.Black, Gender.Male, "Low black Leather Jack Shoe ,Gabor", 1299.90, "Low Black leather shoe from Gabor.Easy to wear.Small heal. Thin sole.Material:Hard Thinn Leather.", 50, "shoes-gb2d1a04bc_640.jpg"));
            Products.Add(new Shoes(202, 42, Colors.Black, Gender.Male, "Low black Leather Jack Shoe ,Gabor", 1299.90, "Low Black leather shoe from Gabor.Easy to wear.Small heal. Thin sole.Material:Hard Thinn Leather.", 39, "shoes-gb2d1a04bc_640.jpg"));
            Products.Add(new Shoes(203, 43, Colors.Black, Gender.Male, "Low black Leather Jack Shoe ,Gabor", 1299.90, "Low Black leather shoe from Gabor.Easy to wear.Small heal. Thin sole.Material:Hard Thinn Leather.", 40, "shoes-gb2d1a04bc_640.jpg"));
            Products.Add(new Shoes(204, 44, Colors.Black, Gender.Male, "Low black Leather Jack Shoe ,Gabor", 1299.90, "Low Black leather shoe from Gabor.Easy to wear.Small heal. Thin sole.Material:Hard Thinn Leather.", 41, "shoes-gb2d1a04bc_640.jpg"));
            Products.Add(new Shoes(205, 45, Colors.Black, Gender.Male, "Low black Leather Jack Shoe ,Gabor", 1299.90, "Low Black leather shoe from Gabor.Easy to wear.Small heal. Thin sole.Material:Hard Thinn Leather.", 35, "shoes-gb2d1a04bc_640.jpg"));
            //4-high black boots with metal clutch side
            Products.Add(new Shoes(206, 41, Colors.Black, Gender.Male, " High Black Boots Jason ,Gabor", 1500.00, "High black leather boots with metall clutch on the side.Thin sole.Pointy edge.Easy and comfotable to wear.Material:black leather", 10, "shoes-gb96916bcc_640.jpg"));
            Products.Add(new Shoes(207, 42, Colors.Black, Gender.Male, " High Black Boots Jason ,Gabor", 1500.00, "High black leather boots with metall clutch on the side.Thin sole.Pointy edge.Easy and comfotable to wear.Material:black leather", 15, "shoes-gb96916bcc_640.jpg"));
            Products.Add(new Shoes(208, 43, Colors.Black, Gender.Male, " High Black Boots Jason ,Gabor", 1500.00, "High black leather boots with metall clutch on the side.Thin sole.Pointy edge.Easy and comfotable to wear.Material:black leather", 16, "shoes-gb96916bcc_640.jpg"));
            Products.Add(new Shoes(209, 44, Colors.Black, Gender.Male, " High Black Boots Jason ,Gabor", 1500.00, "High black leather boots with metall clutch on the side.Thin sole.Pointy edge.Easy and comfotable to wear.Material:black leather", 8, "shoes-gb96916bcc_640.jpg"));
            Products.Add(new Shoes(210,  45, Colors.Black, Gender.Male, " High Black Boots Jason ,Gabor", 1500.00, "High black leather boots with metall clutch on the side.Thin sole.Pointy edge.Easy and comfotable to wear.Material:black leather", 7, "shoes-gb96916bcc_640.jpg"));
            
            //5-sneaker blue and leather
            Products.Add(new Shoes(211, 41, Colors.Blue, Gender.Male, "Blue Leather Mix Sneaker Calson ,Nike", 899.90, "Comfortable mixt style sneaker shoe from Nike Edition Collection.Easy to wear.Thick white sole.Material:Textil,Leather.", 11, "shoes-gc1416130e_640.jpg"));
            Products.Add(new Shoes(212, 42, Colors.Blue, Gender.Male, "Blue Leather Mix Sneaker Calson ,Nike", 899.90, "Comfortable mixt style sneaker shoe from Nike Edition Collection.Easy to wear.Thick white sole.Material:Textil,Leather.", 15, "shoes-gc1416130e_640.jpg"));
            Products.Add(new Shoes(213, 43, Colors.Blue, Gender.Male, "Blue Leather Mix Sneaker Calson ,Nike", 899.90, "Comfortable mixt style sneaker shoe from Nike Edition Collection.Easy to wear.Thick white sole.Material:Textil,Leather.", 2, "shoes-gc1416130e_640.jpg"));
            Products.Add(new Shoes(214, 44, Colors.Blue, Gender.Male, "Blue Leather Mix Sneaker Calson ,Nike", 899.90, "Comfortable mixt style sneaker shoe from Nike Edition Collection.Easy to wear.Thick white sole.Material:Textil,Leather.", 6, "shoes-gc1416130e_640.jpg"));
            Products.Add(new Shoes(215, 45, Colors.Blue, Gender.Male, "Blue Leather Mix Sneaker Calson ,Nike", 899.90, "Comfortable mixt style sneaker shoe from Nike Edition Collection.Easy to wear.Thick white sole.Material:Textil,Leather.", 12, "shoes-gc1416130e_640.jpg"));
            //6-low light brown lether shoe
            Products.Add(new Shoes(216, 41, Colors.LightBrown, Gender.Male, "LightBrown Low Leather Shoe Chester ,Gabor", 999.90, "Low brown lether shoe from Gabor.Lace on front.Thin sole.Material:lightbrown leather", 50, "shoes-men-g296401401_640.jpg"));
            Products.Add(new Shoes(217, 42, Colors.LightBrown, Gender.Male, "LightBrown Low Leather Shoe Chester ,Gabor", 999.90, "Low brown lether shoe from Gabor.Lace on front.Thin sole.Material:lightbrown leather", 39, "shoes-men-g296401401_640.jpg"));
            Products.Add(new Shoes(218, 43, Colors.LightBrown, Gender.Male, "LightBrown Low Leather Shoe Chester ,Gabor", 999.90, "Low brown lether shoe from Gabor.Lace on front.Thin sole.Material:lightbrown leather", 40, "shoes-men-g296401401_640.jpg"));
            Products.Add(new Shoes(219, 44, Colors.LightBrown, Gender.Male, "LightBrown Low Leather Shoe Chester ,Gabor", 999.90, "Low brown lether shoe from Gabor.Lace on front.Thin sole.Material:lightbrown leather", 41, "shoes-men-g296401401_640.jpg"));
            Products.Add(new Shoes(220, 45, Colors.LightBrown, Gender.Male, "LightBrown Low Leather Shoe Chester ,Gabor", 999.90, "Low brown lether shoe from Gabor.Lace on front.Thin sole.Material:lightbrown leather.", 35, "shoes-men-g296401401_640.jpg"));
            //7-*******
            Products.Add(new Shoes(221, 41, Colors.Yellow, Gender.Male, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Lace front.Thick sole.Material:Textil", 10, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(222, 42, Colors.Yellow, Gender.Male, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Lace front.Thick sole.Material:Textil", 0, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(223, 43, Colors.Yellow, Gender.Male, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Lace front.Thick sole.Material:Textil", 3, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(224, 44, Colors.Yellow, Gender.Male, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Lace front.Thick sole.Material:Textil", 7, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(225, 45, Colors.Yellow, Gender.Male, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Lace front.Thick sole.Material:Textil", 9, "shoes-g97acbabf4_640.jpg"));
            //8- leather elastic brown boots
            Products.Add(new Shoes(226, 42, Colors.Brown, Gender.Male, " Brown Elastic Leather Boots ,Gabor", 999.00, "Brown elastic leather boots.Poiny edge.Short sole with mall heel.Material:Brown leather", 7, "shoes-men-g587502cea_640.jpg"));
            Products.Add(new Shoes(227, 43, Colors.Brown, Gender.Male, " Brown Elastic Leather Boots ,Gabor", 999.00, "Brown elastic leather boots.Poiny edge.Short sole with mall heel.Material:Brown leather", 14, "shoes-men-g587502cea_640.jpg"));
            Products.Add(new Shoes(228, 44, Colors.Brown, Gender.Male, " Brown Elastic Leather Boots ,Gabor", 999.00, "Brown elastic leather  boots.Poiny edge.Short sole with mall heel.Material:Brown leather", 9, "shoes-men-g587502cea_640.jpg"));
            Products.Add(new Shoes(229, 45, Colors.Brown, Gender.Male, "Brown Elastic Leather Boots ,Gabor", 999.00, "Brown elastic leather  boots.Poiny edge.Short sole with mall heel.Material:Brown leather", 16, "shoes-men-g587502cea_640.jpg"));
            
            //*******
            Products.Add(new Shoes(230, 41, Colors.DarkBlue, Gender.Male, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(231, 42, Colors.DarkBlue, Gender.Male, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 7, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(232, 43, Colors.DarkBlue, Gender.Male, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 4, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(233, 44, Colors.DarkBlue, Gender.Male, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 0, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(234, 45, Colors.DarkBlue, Gender.Male, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));





            //Woman shoe list:
            //********
            Products.Add(new Shoes(235, 36, Colors.Red, Gender.Female, "Playing with fire Sneaker ,Nike", 899.50, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 50, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(236, 37, Colors.Red, Gender.Female, "Playing with fire Sneaker ,Nike", 899.50, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 39, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(237, 38, Colors.Red, Gender.Female, "Playing with fire Sneaker ,Nike", 899.50, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 40, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(238, 39, Colors.Red, Gender.Female, "Playing with fire Sneaker ,Nike", 899.50, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 41, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(239, 40, Colors.Red, Gender.Female, "Playing with fire Sneaker ,Nike", 899.50, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 35, "shoes-ge69f3f2f1_640.jpg"));



            //1-black high boots
            Products.Add(new Shoes(240, 37, Colors.Black, Gender.Female, "High black boots Lottie ,Gabor", 2399.90, "High lether boot with zip on the side.High heel.Material:Black leather", 14, "woman-g17a9f8ae1_640.jpg"));
            Products.Add(new Shoes(241, 38, Colors.Black, Gender.Female, "High black boots Lottie ,Gabor", 2399.90, "High lether boot with zip on the side.High heel.Material:Black leather", 20, "woman-g17a9f8ae1_640.jpg"));
            Products.Add(new Shoes(242, 39, Colors.Black, Gender.Female, "High black boots Lottie ,Gabor", 2399.90, "High lether boot with zip on the side.High heel.Material:Black leather", 12, "woman-g17a9f8ae1_640.jpg"));
            Products.Add(new Shoes(243, 40, Colors.Black, Gender.Female, "High black boots Lottie ,Gabor", 2399.90, "High lether boot with zip on the side.High heel.Material:Black leather", 10, "woman-g17a9f8ae1_640.jpg"));
            Products.Add(new Shoes(244, 41, Colors.Black, Gender.Female, "High black boots Lottie ,Gabor", 2399.90, "High lether boot with zip on the side.High heel.Material:Black leather", 9, "woman-g17a9f8ae1_640.jpg"));
            //2-snekers  grey
            Products.Add(new Shoes(245, 37, Colors.Grey, Gender.Female, "Grey sneakers Felicity ,Nike", 799.00, "Running sneakers for all seasons.Comfortable sole.Material:Textil,Mocca", 13, "shoes-g4aa27f7db_640.jpg"));
            Products.Add(new Shoes(246, 38, Colors.Grey, Gender.Female, "Grey sneakers Felicity ,Nike", 799.00, "Running sneakers for all seasons.Comfortable sole.Material:Textil,Mocca", 0, "shoes-g4aa27f7db_640.jpg"));
            Products.Add(new Shoes(247, 39, Colors.Grey, Gender.Female, "Grey sneakers Felicity ,Nike", 799.00, "Running sneakers for all seasons.Comfortable sole.Material:Textil,Mocca", 9, "shoes-g4aa27f7db_640.jpg"));
            Products.Add(new Shoes(248, 40, Colors.Grey, Gender.Female, "Grey sneakers Felicity ,Nike", 799.00, "Running sneakers for all seasons.Comfortable sole.Material:Textil,Mocca", 8, "shoes-g4aa27f7db_640.jpg"));
            Products.Add(new Shoes(249, 41, Colors.Grey, Gender.Female, "Grey sneakers Felicity ,Nike", 799.00, "Running sneakers for all seasons.Comfortable sole.Material:Textil,Mocca", 10, "shoes-g4aa27f7db_640.jpg"));
            //3-black high heel
            Products.Add(new Shoes(250, 37, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 21, "shoe-g62b99f93f_640.jpg"));
            Products.Add(new Shoes(251, 37, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 21, "shoe-g62b99f93f_640.jpg"));
            Products.Add(new Shoes(252, 38, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 12, "shoe-g62b99f93f_640.jpg"));
            Products.Add(new Shoes(253, 39, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 10, "shoe-g62b99f93f_640.jpg"));
            Products.Add(new Shoes(254, 40, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 9, "shoe-g62b99f93f_640.jpg"));
            Products.Add(new Shoes(255, 41, Colors.Black, Gender.Female, "Black High heels Ester ,Weekday", 699.90, "Black high heels for New Years Eve.Pointy front.Heel:10cm.Materal:black leather", 8, "shoe-g62b99f93f_640.jpg"));
            

            //******
            Products.Add(new Shoes(256, 37, Colors.Yellow, Gender.Female, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil ", 5, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(257, 38, Colors.Yellow, Gender.Female, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil", 6, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(258, 39, Colors.Yellow, Gender.Female, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil", 16, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(259, 40, Colors.Yellow, Gender.Female, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil", 15, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(260, 41, Colors.Yellow, Gender.Female, "Yellow Spunch Bob,Selected Edition ,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil", 10, "shoes-g97acbabf4_640.jpg"));

            //******
            Products.Add(new Shoes(261, 37, Colors.DarkBlue, Gender.Female, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(262, 38, Colors.DarkBlue, Gender.Female, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 7, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(263, 39, Colors.DarkBlue, Gender.Female, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 4, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(264, 40, Colors.DarkBlue, Gender.Female, "Van Helsing Sneaker ,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 0, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(265, 41, Colors.DarkBlue, Gender.Female, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            //7-red high heel
            Products.Add(new Shoes(266, 37, Colors.Red, Gender.Female, "New Years Eve Red Highheels,Lulu", 1499.90, "Red heigheels.Perfect for party.Heel:10 cm.Material: Red Mocca ", 6, "high-heels-g8c3e44f8e_640.jpg"));
            Products.Add(new Shoes(267, 38, Colors.Red, Gender.Female, "New Years Eve Red Highheels,Lulu", 1499.90, "Red heigheelss.Perfect for party.Heel:10 cm.Material: Red Mocca", 7, "high-heels-g8c3e44f8e_640.jpg")); 
            Products.Add(new Shoes(268, 39, Colors.Red, Gender.Female, "New Years Eve Red Highheels,Lulu", 1499.90, "Red heigheelss.Perfect for party.Heel:10 cm.Material: Red Mocca", 4, "high-heels-g8c3e44f8e_640.jpg"));
            Products.Add(new Shoes(269, 40, Colors.Red, Gender.Female, "New Years Eve Red Highheels,Lulu", 1499.90, "Red heigheelss.Perfect for party.Heel:10 cm.Material: Red Mocca", 0, "high-heels-g8c3e44f8e_640.jpg"));
            Products.Add(new Shoes(270, 41, Colors.Red, Gender.Female, "New Years Eve Red Highheels,Lulu", 1499.90, "Red heigheelss.Perfect for party.Heel:10 cm.Material: Red Movva", 6, "high-heels-g8c3e44f8e_640.jpg"));
            //8-black high heel with bow
            Products.Add(new Shoes(271, 37, Colors.Black, Gender.Female," Black High Heel Col.2,Vans", 849.90, "Black high heels by Van Collection.Perfect for party.Metallic bow on front.Heel:5 cm.Material:plastic", 6, "black-shoes-g5e7238758_640.jpg"));
            Products.Add(new Shoes(272, 38, Colors.Black, Gender.Female, "Black High Heel Col.2,Vans", 849.90, "Black high heels by Van Collection.Perfect for party.Metallic bow on front.Heel:5 cm.Material:plastic", 7, "black-shoes-g5e7238758_640.jpg"));
            Products.Add(new Shoes(273, 39, Colors.Black, Gender.Female, "Black High Heel Col.2,Vans", 849.90, "Black high heels by Van Collection.Perfect for party.Metallic bow on front.Heel:5 cm.Material:plastic", 4, "black-shoes-g5e7238758_640.jpg"));
            Products.Add(new Shoes(274, 40, Colors.Black, Gender.Female, "Black High Heel Col.2,Vans", 849.90, "Black high heels by Van Collection.Perfect for party.Metallic bow on front.Heel:5 cm.Material:plastic", 0, "black-shoes-g5e7238758_640.jpg"));
            Products.Add(new Shoes(275, 41, Colors.Black, Gender.Female, "Black High Heel Col.2,Vans", 849.90, "Black high heels by Van Collection.Perfect for party.Metallic bow on front.Heel:5 cm.Material:plastic", 6, "black-shoes-g5e7238758_640.jpg"));
            //*******
            Products.Add(new Shoes(276, 37, Colors.Blue, Gender.Female, " Blue Speed Snekers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 2, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(277, 38, Colors.Blue, Gender.Female, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 5, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(278, 39, Colors.Blue, Gender.Female, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 15, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(279, 40, Colors.Blue, Gender.Female, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 4, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(280, 41, Colors.Blue, Gender.Female, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 2, "shoes-g28b7de332_640.jpg"));


            //UNISEX SHOE LIST:

            //1-yellow sneaker
            Products.Add(new Shoes(281, 37, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition. Thick sole.Material:Textil ", 5, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(282, 38, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 6, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(283, 39, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 16, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(284, 40, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 15, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(285, 41, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 10, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(286, 42, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 0, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(287, 43, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 3, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(288, 44, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 7, "shoes-g97acbabf4_640.jpg"));
            Products.Add(new Shoes(289, 45, Colors.Yellow, Gender.Unisex, "Yellow Spunch Bob,Selected Edition,Weary", 1449.90, "Yellow sneaker inspired by character Spunch Bob.Limited Edition.Thick sole.Material:Textil", 9, "shoes-g97acbabf4_640.jpg"));
            
            

            //3-sneaker blue with red print
            Products.Add(new Shoes(290, 37, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(291, 38, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 7, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(292, 39, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 4, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(293, 40, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 0, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(294, 41, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(295, 42, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(296, 43, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(297, 44, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            Products.Add(new Shoes(298, 45, Colors.DarkBlue, Gender.Unisex, "Van Helsing Sneaker,Vans", 1300.90, "Cool mixt color sneakers from Van Collection.Good comfort for running or walking.Material: Blue textil with red print", 6, "shoe-g20d012bc7_640.jpg"));
            //4-blue sneaker
            Products.Add(new Shoes(299, 37, Colors.Blue, Gender.Unisex, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 2, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(300, 38, Colors.Blue, Gender.Unisex, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 5, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(301, 39, Colors.Blue, Gender.Unisex, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 15, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(302, 40, Colors.Blue, Gender.Unisex, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 4, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(303, 41, Colors.Blue, Gender.Unisex, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 2, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(304, 42, Colors.Blue, Gender.Unisex, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 5, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(305, 43, Colors.Blue, Gender.Unisex, " Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 15, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(306, 44, Colors.Blue, Gender.Unisex, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 4, "shoes-g28b7de332_640.jpg"));
            Products.Add(new Shoes(307, 45, Colors.Blue, Gender.Unisex, "Blue Speed Sneakers,Sketchers", 599.50, "Sneaker shoe that is easy to wear.Material:Textil,Mocca.", 4, "shoes-g28b7de332_640.jpg"));

            //5-red sneaker
            Products.Add(new Shoes(308, 36, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 50, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(309, 37, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 39, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(310, 38, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 40, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(311, 39, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 41, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(312, 40, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 35, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(313, 41, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 50, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(314, 42, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 39, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(315, 43, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 40, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(316, 44, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 41, "shoes-ge69f3f2f1_640.jpg"));
            Products.Add(new Shoes(317, 45, Colors.Red, Gender.Unisex, "Playing with fire Sneaker,Nike", 899.90, "Comfortable sneaker shoe from Nike Edition Collection.Easy to wear.Thick sole.Material:Mocca.", 35, "shoes-ge69f3f2f1_640.jpg"));





            //
            // Jackets
            // public Jackets(int index,int size, Colors color, Gender gender, string name, double shoe,double price, string description, int stock, JacketLenght jacketLenght, string imageLink)
            //Male jacket list
            //1-Blue sailor jacket
            Products.Add(new Jackets(318, "XSmall", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 15, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            Products.Add(new Jackets(319,"Small", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 10, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            Products.Add(new Jackets(320,"Medium", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 7, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            Products.Add(new Jackets(321,"Large", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 7, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            Products.Add(new Jackets(322,"XLarge", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 3, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            Products.Add(new Jackets(323, "XXLarge", Colors.DarkBlue, Gender.Male, "Fancy Blue SailorJacket,Acne", 699.00, "Blue Winter SailorJacket for men.Close with button.Material:Woolmix", 0, JacketLenght.Long, "beanie-gfb5f7f422_640.jpg"));
            //2-bomber jacket NY
            Products.Add(new Jackets(324, "XSmall", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 5, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            Products.Add(new Jackets(325, "Small", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 7, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            Products.Add(new Jackets(326, "Medium", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 6, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            Products.Add(new Jackets(327, "Large", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 12, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            Products.Add(new Jackets(328, "XLarge", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 10, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            Products.Add(new Jackets(329, "XXLarge", Colors.Blue, Gender.Male, "New York Bomber Jacket,Target", 1499.00, "Blue/White Male Bomber Jacket.Logo:NY on the front Material:Woolmix", 10, JacketLenght.Medium, "man-g1c1df0ac3_640.jpg"));
            //3-Long grey jacket
            Products.Add(new Jackets(330, "XSmall", Colors.Grey, Gender.Male, "Lucifer Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 5, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            Products.Add(new Jackets(331, "Small", Colors.Grey, Gender.Male, "Lucifer Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 10, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            Products.Add(new Jackets(332, "Medium", Colors.Grey, Gender.Male, "Lucifer Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 8, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            Products.Add(new Jackets(333, "Large", Colors.Grey, Gender.Male, "Lucifer Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 2, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            Products.Add(new Jackets(334, "XLarge", Colors.Grey, Gender.Male, "Lucifer Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 10, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            Products.Add(new Jackets(335, "XXLarge", Colors.Grey, Gender.Male, "Lucifer  Winter Coat Male,Acne", 799.00, "Long Grey Winter Coat.Zipfly and botton front.Material:Woolmix", 6, JacketLenght.Long, "jacket-g31c0d11b1_640.jpg"));
            //4-brown black jacket 
            Products.Add(new Jackets(336, "XSmall", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, " Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 2, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            Products.Add(new Jackets(337, "Small", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, "Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 13, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            Products.Add(new Jackets(338, "Medium", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, " Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 9, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            Products.Add(new Jackets(339, "Large", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, " Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 17, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            Products.Add(new Jackets(340, "XLarge", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, " Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 9, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            Products.Add(new Jackets(341, "XXLarge", Colors.Brown, Gender.Male, "Brown Black Jacket,Acne", 1149.00, " Male Jacket.Short upper collar.Brown with black sleeves.Material:Cotton,Polyester,Line", 10, JacketLenght.Medium, "jacket-g063fc26e7_640.jpg"));
            //5-black nylon jacket 
            Products.Add(new Jackets(342, "XSmall", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern.Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            Products.Add(new Jackets(343, "Small", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern.Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            Products.Add(new Jackets(344, "Medium", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern.Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            Products.Add(new Jackets(345, "Large", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern.Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            Products.Add(new Jackets(346, "XLarge", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern..Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            Products.Add(new Jackets(347, "XXLarge", Colors.Black, Gender.Male, "Black Paddern Nylon Jacket,Carling", 799.00, "Short fall black jacket with pattern..Zipfly and buttons front.Material:Nylon", 10, JacketLenght.Medium, "jacket-g72f565b5e_640.jpg"));
            //*********
            Products.Add(new Jackets(348, "XSmall", Colors.Lightblue, Gender.Male, "Short Jeans Jacket ,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 8, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(349, "Small", Colors.Lightblue, Gender.Male, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 10, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(350, "Medium", Colors.Lightblue, Gender.Male, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 11, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(351, "Large", Colors.Lightblue, Gender.Male, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(352, "XLarge", Colors.Lightblue, Gender.Male, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(353, "XXLarge", Colors.Lightblue, Gender.Male, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button.", 20, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            //*******
            Products.Add(new Jackets(354, "XSmall", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.90, " Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 14, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(355, "Small", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.90, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 16, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(356, "Medium", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.90, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 8, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(357, "Large", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket ,Rock and Roll", 1689.90, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 4, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(358, "XLarge", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.90, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 7, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(359, "XXLarge", Colors.Black, Gender.Male, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.90, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 12, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));

            
            

            







            //Woman jacket list:

            //1-brown bomber jacket
            Products.Add(new Jackets(360, "XSmall", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 3, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            Products.Add(new Jackets(361, "Small", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 7, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            Products.Add(new Jackets(362, "Medium", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 10, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            Products.Add(new Jackets(363, "Large", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 10, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            Products.Add(new Jackets(364, "XLarge", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 8, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            Products.Add(new Jackets(365, "XXLarge", Colors.Brown, Gender.Female, "Lucile Winter BomberJacket,Carling", 599.00, "Winter Bomber jacket with hoodie.Material:Nylon", 12, JacketLenght.Medium, "cold-g4e24ae741_640.jpg"));
            
           
            //3-white leather jacket
            Products.Add(new Jackets(366, "XSmall", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 6, JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            Products.Add(new Jackets(367, "Small", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 0, JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            Products.Add(new Jackets(368, "Medium", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 10 , JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            Products.Add(new Jackets(369, "Large", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 8, JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            Products.Add(new Jackets(370, "XLarge", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 9, JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            Products.Add(new Jackets(371, "XXLarge", Colors.White, Gender.Female, "White Leather Woman Jacket,Acne", 1799.00, "White leather jacket with pocket on the side and cheast.Zipfly to close.Material:Leather", 8, JacketLenght.Short, "fashion-g77d6b91d6_640.jpg"));
            //4- medium jeans jacket with pink print
           
            Products.Add(new Jackets(372, "XSmall", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 1099.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 21, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            Products.Add(new Jackets(373, "Small", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 1099.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 25, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            Products.Add(new Jackets(374, "Medium", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 399.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 25, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            Products.Add(new Jackets(375, "Large", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 399.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 17, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            Products.Add(new Jackets(376, "XLarge", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 399.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 16, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            Products.Add(new Jackets(377, "XXLarge", Colors.Lightblue, Gender.Female, "Blue Jeans Jacket with pink print,Admin", 399.00, "Short light blue jeans jacket with pink print. Chest pocket. Button closer.", 26, JacketLenght.Medium, "woman-g7fb3c1fa5_640.jpg"));
            //********
            Products.Add(new Jackets(378, "XSmall", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 14, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(379, "Small", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 16, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(380, "Medium", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 8, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(381, "Large", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 4, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(382, "XLarge", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 7, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(383, "XXLarge", Colors.Black, Gender.Female, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 12, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));

            //********
            Products.Add(new Jackets(384, "XSmall", Colors.Lightblue, Gender.Female, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 8, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(385, "Small", Colors.Lightblue, Gender.Female, "Short Jeans Jacket ,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 10, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(386, "Medium", Colors.Lightblue, Gender.Female, "Short Jeans  Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 11, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(387, "Large", Colors.Lightblue, Gender.Female, "Short Jeans Jacket ,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(388, "XLarge", Colors.Lightblue, Gender.Female, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(389, "XXLarge", Colors.Lightblue, Gender.Female, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 20, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            
            
            //8-pink coat 
            
            Products.Add(new Jackets(390, "XSmall", Colors.Pink, Gender.Female, "Pink Long Coat,Colmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 8, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            Products.Add(new Jackets(391, "Small", Colors.Pink, Gender.Female, "Pink Long Coat,Colmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 10, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            Products.Add(new Jackets(392, "Medium", Colors.Pink, Gender.Female, "Pink Long Coat,Colmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 11, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            Products.Add(new Jackets(393, "Large", Colors.Pink, Gender.Female, "Pink Long Coat,Colmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 17, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            Products.Add(new Jackets(394, "XLarge", Colors.Pink, Gender.Female, "Pink Long Coat,Coldmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 17, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            Products.Add(new Jackets(395, "XXLarge", Colors.Pink, Gender.Female, "Pink Long Coat,Colmine", 2799.00, "Long pink woolmix coat with side pockets.Material:WoolMix", 20, JacketLenght.Long, "people-g24259b15b_640.jpg"));
            //9-green coat
            Products.Add(new Jackets(396, "XSmall", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 8, JacketLenght.Long, "girl-gb757e251f_640.jpg"));
            Products.Add(new Jackets(397, "Small", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 10, JacketLenght.Long, "girl-gb757e251f_640.jpg"));
            Products.Add(new Jackets(398, "Medium", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 11, JacketLenght.Long, "girl-gb757e251f_640.jpg"));
            Products.Add(new Jackets(399, "Large", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 17, JacketLenght.Long, "girl-gb757e251f_640.jpg"));
            Products.Add(new Jackets(400, "XLarge", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 17, JacketLenght.Long, "girl-gb757e251f_640.jpg"));
            Products.Add(new Jackets(401, "XXLarge", Colors.Green, Gender.Female, "Darkgreen trenchcoat Lalla,Acne", 2499.90, "Darkgreen coat with waist belt.Black buttons to close.Material:Lyocell", 20, JacketLenght.Long, "girl-gb757e251f_640.jpg"));





            //Unisex jackets
            //1-light blue jeans jacket
            Products.Add(new Jackets(402, "XSmall", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 8, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(403, "Small", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket ,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 10, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(404, "Medium", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 11, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(405, "Large", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(406, "XLarge", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 17, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            Products.Add(new Jackets(407, "XXLarge", Colors.Lightblue, Gender.Unisex, "Short Jeans Jacket,Admin", 649.00, "Jeans jacket from label Admin.Side pockets with zipfly and chest pocket with button", 20, JacketLenght.Short, "jeans-g2fcb8a16b_640.jpg"));
            
            
            //3- black leather jacket short**
            Products.Add(new Jackets(408, "XSmall", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 14, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(409, "Small", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 16, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(410, "Medium", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 8, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(411, "Large", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00,"Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 4, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(412, "XLarge", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 7, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
            Products.Add(new Jackets(413, "XXLarge", Colors.Black, Gender.Unisex, "Black Bad Ass Leather Jacket,Rock and Roll", 1689.00, "Short black leather jacket with sidepocket.Zipfly closing jacket and pocket.Loose belt arond the waist Material: Leather", 12, JacketLenght.Short, "woman-g3faf51d8b_640.jpg"));
           


            // Underwear
            // public Underwear(int index,int size, Colors color, Gender gender, string name, double price, string description, int stock, UnderwearSexyness underwearSexyness, string imageLink)
            //Male underwear

            //1-orange breaf male
            Products.Add(new Underwear(414,"XSmall", Colors.Orange, Gender.Male, "Orange Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 10, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            Products.Add(new Underwear(415,"Small", Colors.Orange, Gender.Male, "Orange Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 8, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            Products.Add(new Underwear(416,"Medium", Colors.Orange, Gender.Male, "Orange Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 8, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            Products.Add(new Underwear(417,"Large", Colors.Orange, Gender.Male, "Orange Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 10, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            Products.Add(new Underwear(418,"XLarge", Colors.Orange, Gender.Male, "Orange Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 12, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            Products.Add(new Underwear(419, "XXLarge", Colors.Orange, Gender.Male, "Orange Basic  Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 10, UnderwearSexyness.NotSexy, "underpants-g681442c5d_640.jpg"));
            //2-blue color cotton bief
            Products.Add(new Underwear(420,"XSmall", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, "Blue color cottonbriefs. The underpants have elastic at the waist and medium - length legs.Lined front.", 19, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            Products.Add(new Underwear(421,"Small", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, " Blue color cottonbriefs.The underpants have elastic at the waist and medium - length legs.Lined front.", 23, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            Products.Add(new Underwear(422,"Medium", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, " Blue color cottonbriefs.The underpants have elastic at the waist and medium - length legs.Lined front.", 10, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            Products.Add(new Underwear(423,"Large", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, "Blue color cottonbriefs.The underpants have elastic at the waist and medium - length legs.Lined front.", 7, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            Products.Add(new Underwear(424,"XLarge", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, " Blue color cottonbriefs.The underpants have elastic at the waist and medium - length legs.Lined front.", 12, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            Products.Add(new Underwear(425,"XXLarge", Colors.Blue, Gender.Male, "Blue cotton Breifs,Frank Dandy", 299.90, "Blue color cottonbriefs. The underpants have elastic at the waist and medium - length legs.Lined front.", 10, UnderwearSexyness.NotSexy, "men-underwear.jpg"));
            // lightblue color
            Products.Add(new Underwear(426, "XSmall", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 13, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            Products.Add(new Underwear(427, "Small", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 23, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            Products.Add(new Underwear(428, "Medium", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 15, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            Products.Add(new Underwear(429, "Large", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 7, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            Products.Add(new Underwear(430, "XLarge", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 12, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            Products.Add(new Underwear(431, "XXLarge", Colors.Lightblue, Gender.Male, "Lightblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 18, UnderwearSexyness.NotSexy, "underwear (1).jpg"));
            //darkblue color
            Products.Add(new Underwear(432, "XSmall", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 13, UnderwearSexyness.NotSexy, "underwear.jpg"));
            Products.Add(new Underwear(433, "Small", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 12, UnderwearSexyness.NotSexy, "underwear.jpg"));
            Products.Add(new Underwear(434, "Medium", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 10, UnderwearSexyness.NotSexy, "underwear.jpg"));
            Products.Add(new Underwear(435, "Large", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 2, UnderwearSexyness.NotSexy, "underwear.jpg"));
            Products.Add(new Underwear(436, "XLarge", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, " Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 12, UnderwearSexyness.NotSexy, "underwear.jpg"));
            Products.Add(new Underwear(437, "XXLarge", Colors.DarkBlue, Gender.Male, "Darkblue Basic Boxer,Frank Dandy", 199.90, "Trunks in stretchy cotton knit with flatlock seams for increased comfort. The underpants have elastic at the waist and medium-length legs. Lined front.", 1, UnderwearSexyness.NotSexy, "underwear.jpg"));

            
            //socks-orange dotts socks**
            Products.Add(new Underwear(438,"40/42", Colors.Orange, Gender.Male, "Orange Blackblue Dotts Socks,Happy Socks", 59.90, "A pair of finely knitted orange socks in a soft cotton blend.White line front.Black bigg dotts.", 57, UnderwearSexyness.NotSexy, "feet-g9807d4573_640.jpg"));
            Products.Add(new Underwear(439,"43/45", Colors.Orange, Gender.Male, "Orange Blackblue Dotts Socks,Happy Socks", 59.90, "A pair of finely knitted orange socks in a soft cotton blend.White line front.Black big dotts.", 56, UnderwearSexyness.NotSexy, "feet-g9807d4573_640.jpg"));
            Products.Add(new Underwear(440,"46/48", Colors.Orange, Gender.Male, "Orange Blackblue Dotts Socks,Happy Socks", 59.90, "A pair of finely knitted orange socks in a soft cotton blend.White line front.Black big dotts.", 46, UnderwearSexyness.NotSexy, "feet-g9807d4573_640.jpg"));
            
            //-black socks**
            Products.Add(new Underwear(441,"40/42", Colors.Black, Gender.Male, "Black Socks,Basic True", 59.90, "A pair of finely knitted black socks in a soft cotton blend.", 57, UnderwearSexyness.NotSexy, "pexels-ryutaro-tsukata-5746098.jpg"));
            Products.Add(new Underwear(442,"43/45", Colors.Black, Gender.Male, "Black Socks,Basic True", 59.90, "A pair of finely knitted black socks in a soft cotton blend.", 56, UnderwearSexyness.NotSexy, "pexels-ryutaro-tsukata-5746098.jpg"));
            Products.Add(new Underwear(443,"46/48", Colors.Black, Gender.Male, "Black Socks,Basic True", 59.90, "A pair of finely knitted black socks in a soft cotton blend.", 46, UnderwearSexyness.NotSexy, "pexels-ryutaro-tsukata-5746098.jpg"));
            
            //-blue/red stripe socks **
            Products.Add(new Underwear(444,"40/42", Colors.DarkBlue, Gender.Male, "Red stripe darkblue socks,Happy Socks", 59.90, "A pair of finely knitted darkblue socks with red stripes  in a soft cotton blend", 52, UnderwearSexyness.NotSexy, "feet-g748e1adf4_640.jpg"));
            Products.Add(new Underwear(445,"43/45", Colors.DarkBlue, Gender.Male, "Red stripe darkblue socks,Happy Socks", 59.90, "A pair of finely knitted darkblue socks with red stripes  in a soft cotton blend", 56, UnderwearSexyness.NotSexy, "feet-g748e1adf4_640.jpg"));
            Products.Add(new Underwear(446,"46/48", Colors.DarkBlue, Gender.Male, "Red stripe darkblue socks,Happy Socks", 59.90, "A pair of finely knitted darkblue socks with red stripes  in a soft cotton blend.", 46, UnderwearSexyness.NotSexy, "feet-g748e1adf4_640.jpg"));
            
            //-black/ white small dotts socks**
            Products.Add(new Underwear(447,  "40/42", Colors.Black, Gender.Male, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 57, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(448, "43/45", Colors.Black, Gender.Male, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 56, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(449,  "46/48", Colors.Black, Gender.Male, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 46, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            
            //2-pack grey socks**
            Products.Add(new Underwear(450, "40/42", Colors.Greyblue, Gender.Male, "2-pack grey/blue socks,Basic True", 99.90, "2-pack socks of finely knitted cotton blend.Blue with stripes and grey socks.", 50, UnderwearSexyness.NotSexy, "socks-gd053a94ff_640.jpg"));
            Products.Add(new Underwear(451, "43/45", Colors.Greyblue, Gender.Male, "2-pack grey/blue socks,Basic True", 99.90, "2-pack socks of finely knitted cotton blend.Blue with stripes and grey socks.", 60, UnderwearSexyness.NotSexy, "socks-gd053a94ff_640.jpg"));
            Products.Add(new Underwear(452, "46/48", Colors.Greyblue, Gender.Male, "2-pack grey/blue socks,Basic True", 99.90, "2-pack socks of finely knitted cotton blend.Blue with stripes and grey socks.", 42, UnderwearSexyness.NotSexy, "socks-gd053a94ff_640.jpg"));
            //red striped socks
            Products.Add(new Underwear(453, "40/42", Colors.Red, Gender.Male, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 45, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(454, "43/45", Colors.Red, Gender.Male, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 59, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(455, "46/48", Colors.Red, Gender.Male, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 43, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            //Woman underwear(bra,socks)
            //-purple bra**
            Products.Add(new Underwear(456,"XSmall", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 5, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            Products.Add(new Underwear(457,"Small", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 13, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            Products.Add(new Underwear(458,"Medium", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 10, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            Products.Add(new Underwear(459,"Large", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 11, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            Products.Add(new Underwear(460,"XLarge", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 8, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            Products.Add(new Underwear(461, "XXLarge", Colors.Purple, Gender.Female, "Purpule Lace Bra,Basic True", 499.90, "Push-up bras in soft cotton knit with lace. The bras have a jumper and molded, padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and narrow buttoning at the back.", 15, UnderwearSexyness.Sexy, "woman-gabf216686_640.jpg"));
            // white bra**
            Products.Add(new Underwear(462,"XSmall", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 21, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            Products.Add(new Underwear(463,"Small", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 35, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            Products.Add(new Underwear(464,"Medium", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 24, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            Products.Add(new Underwear(465,"Large", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 27, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            Products.Add(new Underwear(466,"XLarge", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 26, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            Products.Add(new Underwear(467,"XXLarge", Colors.White, Gender.Female, "White push-up bra,Basic True", 299.90, "A push up bra in tricot. The bra has a strap and padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps and elastic edge at the bottom. Buttoning at the back with hooks.Has fold pattern and not front.", 36, UnderwearSexyness.Sexy, "woman-g7dbd7d9cd_640.jpg"));
            //-black bra**
            Products.Add(new Underwear(468,"XSmall", Colors.Black, Gender.Female, "Seamless  black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin.", 15, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            Products.Add(new Underwear(469,"Small", Colors.Black, Gender.Female, "Seamless black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin.", 30, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            Products.Add(new Underwear(470,"Medium", Colors.Black, Gender.Female, "Seamless black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin.", 21, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            Products.Add(new Underwear(471,"Large", Colors.Black, Gender.Female, "Seamless black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin.", 22, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            Products.Add(new Underwear(472,"XLarge", Colors.Black, Gender.Female, "Seamless black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin..", 29, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            Products.Add(new Underwear(473,"XXLarge", Colors.Black, Gender.Female, "Seamless black push-up bra in micro,Basic True", 399.90, "A soft, strapless push-up bra in ribbed micro with a normal edge at the bottom. The bra has padded cups that give a larger bust and a fuller neckline. Adjustable shoulder straps. Lacks buttoning. The bra is designed with a minimal number of seams for a seamless, comfortable feeling against the skin.", 35, UnderwearSexyness.Sexy, "woman-g9b20705a9_640.jpg"));
            //pink bra lace**
            Products.Add(new Underwear(474, "XSmall", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 15, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            Products.Add(new Underwear(475, "Small", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 12, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            Products.Add(new Underwear(476, "Medium", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 21, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            Products.Add(new Underwear(477, "Large", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 16, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            Products.Add(new Underwear(478, "XLarge", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 29, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            Products.Add(new Underwear(479, "XXLarge", Colors.Pink, Gender.Female, "Pink Lace Bra,Frank Dandy", 499.90, "A soft, strapless pink bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 32, UnderwearSexyness.Sexy, "bright-pink-bralette.jpg"));
            //red bra lace**
            Products.Add(new Underwear(480, "XSmall", Colors.Red, Gender.Female, "Red Lace Bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 10, UnderwearSexyness.Sexy, "red-bralette.jpg"));
            Products.Add(new Underwear(481, "Small", Colors.Red, Gender.Female, "Red Lace Bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 35, UnderwearSexyness.Sexy, "red-bralette.jpg"));
            Products.Add(new Underwear(482, "Medium", Colors.Red, Gender.Female, "Red Lace Bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 21, UnderwearSexyness.Sexy, "red-bralette.jpg"));
            Products.Add(new Underwear(483, "Large", Colors.Red, Gender.Female, "Red Lace Bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 20, UnderwearSexyness.Sexy, " red-bralette.jpg"));
            Products.Add(new Underwear(484, "XLarge", Colors.Red, Gender.Female, "Red Lace Bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 20, UnderwearSexyness.Sexy, " red-bralette.jpg"));
            Products.Add(new Underwear(485, "XXLarge", Colors.Red, Gender.Female, "Red Lace bra,Frank Dandy", 499.90, "A soft, strapless red bra in lace.Small shoulder straps and small lace edge at the bottom. Lacks buttoning.", 32, UnderwearSexyness.Sexy, "red-bralette.jpg"));
            //black bra lace**
            Products.Add(new Underwear(486, "XSmall", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 6, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            Products.Add(new Underwear(487, "Small", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 30, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            Products.Add(new Underwear(488, "Medium", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 20, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            Products.Add(new Underwear(489, "Large", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 22, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            Products.Add(new Underwear(490, "XLarge", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 24, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            Products.Add(new Underwear(491, "XXLarge", Colors.Black, Gender.Female, "Black Lace Bra,Frank Dandy", 499.90, "A soft, strapless black bra in lace.Small shoulder straps and small lace edge at the bottom.Lacks buttoning.", 35, UnderwearSexyness.Sexy, "bralette-lingerie.jpg"));
            //-blue 3-pack socks woman**
            Products.Add(new Underwear(492, "37/39", Colors.Blue, Gender.Female, "3-pack Basic Blue socks,Basic True", 99.90, "Finely knitted blue and grey socks in cotton blended quality with shaft. Elastic at the top.", 59, UnderwearSexyness.NotSexy, "sock-gdb28dabf3_640.jpg"));
            Products.Add(new Underwear(493, "40/42", Colors.Blue, Gender.Female, "3-pack Basic Blue socks,Basic True", 99.90, "Finely knitted blue and grey socks in cotton blended quality with shaft. Elastic at the top.", 57, UnderwearSexyness.NotSexy, "sock-gdb28dabf3_640.jpg"));
            //-green socks**
            Products.Add(new Underwear(494, "37/39", Colors.Green, Gender.Female, "Green socks,Frank Dandy", 59.90, "Finely knitted socks in cottonmix blended quality with shaft. Elastic at the top.", 56, UnderwearSexyness.NotSexy, "pexels-cottonbro-6764102.jpg"));
            Products.Add(new Underwear(495, "40/42", Colors.Green, Gender.Female, "Green socks,Frank Dandy", 59.90, "Finely knitted socks in cottonmix blended quality with shaft. Elastic at the top.", 50, UnderwearSexyness.NotSexy, "pexels-cottonbro-6764102.jpg"));
            //red striped socks
            Products.Add(new Underwear(496, "37/39", Colors.Red, Gender.Female, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 53, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(497, "40/42", Colors.Red, Gender.Female, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 45, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            //black/white small dotts socks
            Products.Add(new Underwear(498, "37/39", Colors.Black, Gender.Female, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 53, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(499, "40/42", Colors.Black, Gender.Female, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 52, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));


            //UNISEX UNDERWEAR
            //-red striped socks**
            Products.Add(new Underwear(500, "37/39", Colors.Red, Gender.Unisex, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 53, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(501, "40/42", Colors.Red, Gender.Unisex, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 45, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(502, "43/45", Colors.Red, Gender.Unisex, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 59, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            Products.Add(new Underwear(503, "46/48", Colors.Red, Gender.Unisex, "Red striped basic socks,Frank Dandy", 69.90, "Finely knitted socks in cotton blended quality with shaft. Elastic at the top.Red with grey and purple stripes.", 43, UnderwearSexyness.NotSexy, "socks-g74fc901e7_640.jpg"));
            //black/white small dotts socks
            Products.Add(new Underwear(504, "37/39", Colors.Black, Gender.Female, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 53, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(505, "40/42", Colors.Black, Gender.Female, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 52, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(506, "43/45", Colors.Black, Gender.Male, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 56, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            Products.Add(new Underwear(507, "46/48", Colors.Black, Gender.Male, "Black socks with white small dotts,Happy Socks", 79.90, "A pair of finely knitted black socks with small white spots in a soft cotton blend.", 46, UnderwearSexyness.NotSexy, "pexels-mwabonje-4225294.jpg"));
            return Products;
        }
    }
}
