﻿using System;
using System.Net.Http;

namespace HttpSäätiedot
{
    class Program
    {
        static void Main(string[] args)
        {
            string kaupunki = "Tampere";
            Console.WriteLine($"Aloitetaan säätietojen haku kaupungista {kaupunki}.");

            HttpClient client = new HttpClient();
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={kaupunki}&appid=f9463bc94dd7f584483b04a3a49f18ba";

            HttpResponseMessage vastaus = client.GetAsync(url).Result;
            string json = vastaus.Content.ReadAsStringAsync().Result;

            Console.WriteLine(json);
        }
    }
}
