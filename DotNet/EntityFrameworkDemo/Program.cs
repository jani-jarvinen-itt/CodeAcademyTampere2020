using System;
using System.Linq;
using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avataan tietokantayhteys...");
            NorthwindContext konteksti = new NorthwindContext();

            int lkm = konteksti.Customers.Count();
            Console.WriteLine("Asiakkaiden lukumäärä: " + lkm);

            lkm = konteksti.Orders.Count();
            Console.WriteLine("Tilausten lukumäärä: " + lkm);

            konteksti.Dispose();
            Console.WriteLine("Tietokantayhteys suljettu.");
        }
    }
}
