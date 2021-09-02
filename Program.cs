using System;

namespace homesatcode1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tshirt shop = new Tshirt();
            int sizeL;
            sizeL = 500;
            int sizeM;
            sizeM = 750;
            int sizeS;
            sizeS = 625;
            Console.WriteLine(shop.size);
            Console.WriteLine(shop.color);
            Console.WriteLine(shop.price);
            Console.WriteLine(shop.image);
            Console.WriteLine("ShoppingCart");
            Console.WriteLine("size L Red 500 bath");
            Console.WriteLine("size M Black 750 bath");
            Console.WriteLine("size S Pink 625 bath");


            User jame = new User();
            Console.WriteLine("jame watson",jame.name);
            Console.WriteLine("email : jame@gmail.com",jame.email);


            Address user = new Address();
            Console.Write("131/75,Phutthamonthon Road",user.street);
            Console.Write(" Nakhon Pathom", user.city);
            Console.WriteLine(" zipCode 10180",user.zipCode);

            Console.WriteLine("Total cost = {0} bath.", sizeL + sizeM + sizeS);
        }

        class Tshirt
        {
            public string size;
            public string color;
            public float price;
            public string image;
        }
        class User 
        {
            public string name;
            public string email;
            public string ShoppingCart;
        }
        class Address 
        {
            public string street;
            public string city;
            public string zipCode;
        }
    }
}
