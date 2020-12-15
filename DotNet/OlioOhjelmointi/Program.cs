using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // auto 1
            Auto oma = new Auto()
            {
                Väri = "punainen",
                Huippunopeus = 210
            };
            oma.Käynnistä();
            oma.Kiihdytä();

            // auto 2
            Auto naapurin = new Auto() {
                Väri = "harmaa",
                Huippunopeus = 190
            };
            naapurin.Käynnistä();
        }
    }
}
