using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku 1:");
            string syöte = Console.ReadLine();

            Console.WriteLine("Anna luku 2:");
            string syöte2 = Console.ReadLine();

            int luku1 = int.Parse(syöte);
            int luku2 = int.Parse(syöte2);
            int summa = luku1 + luku2;
            Console.WriteLine(summa);
        }
    }
}
