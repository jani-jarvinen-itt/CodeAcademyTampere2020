using System;

namespace ArvaaLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Arvaa luku -peliin!");
            Random rnd = new Random();
            int oikeaVastaus = rnd.Next(1, 21);
            Console.WriteLine(oikeaVastaus);

            for (int arvauskerta = 0; arvauskerta < 3; arvauskerta++)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                int arvaus = int.Parse(Console.ReadLine());

                if (arvaus < oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvaus > oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein, hyvä!");
                    break;
                }
            }

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
