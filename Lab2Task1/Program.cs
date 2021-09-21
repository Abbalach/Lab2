using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 466541;
            address.Country = "Ukraine";
            address.City = "Kiyv";
            address.Street = "Vladimirskaya";
            address.House = "49a";
            address.Apartment = 12;
            Console.WriteLine("Index = " + address.Index + ", country = " + address.Country + ", city = " 
                + address.City + ", street = " + address.Street + ", house = " + address.House + ", apartment = " + address.Apartment);
            Console.ReadKey();
        }
    }
}
