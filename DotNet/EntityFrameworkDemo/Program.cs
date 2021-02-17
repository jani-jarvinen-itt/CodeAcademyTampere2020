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

            // harjoitus 2
            lkm = (from e in konteksti.Employees
                   where e.City == "London"
                   select e).Count();
            Console.WriteLine("Harjoitus 2.1, Lontoossa olevat työntekijät: " + lkm);

            var suomalaiset = (from c in konteksti.Customers
                               where c.Country == "Finland"
                               select c).ToList();
            foreach (var suomalainen in suomalaiset) {
                Console.WriteLine("Suomalainen asiakas: " + suomalainen.CompanyName);
            }

            lkm = (from o in konteksti.Orders
                   where o.OrderDate >= new DateTime(1996,1,1) &&
                         o.OrderDate < new DateTime(1997,1,1)
                   select o).Count();
            Console.WriteLine("Harjoitus 2.3, vuoden 1996 tilausten määrä: " + lkm);

            konteksti.Dispose();
            Console.WriteLine("Tietokantayhteys suljettu.");
        }
    }
}
