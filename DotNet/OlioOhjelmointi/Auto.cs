using System;

namespace OlioOhjelmointi
{
    public class Auto
    {
        public string Merkki { get; set; }

        public string Malli { get; set; }

        public int Huippunopeus { get; set; }

        public string Väri { get; set; }

        public int Nopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        public void Käynnistä()
        {
            MoottoriKäynnissä = true;
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
        }

        public void Kiihdytä()
        {
            Nopeus += 5; // Nopeus = Nopeus + 5;

            if (Nopeus > Huippunopeus) {
                Nopeus = Huippunopeus;
            }
        }

        public void Jarruta()
        {
            Nopeus -= 5;
            
            if (Nopeus < 0) {
                Nopeus = 0;
            }
        }
    }
}
