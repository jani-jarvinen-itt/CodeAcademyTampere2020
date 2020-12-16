using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HttpSäätiedot
{
    class Program
    {
        static void Main(string[] args)
        {
            const string kaupunki = "Tampere";
            const string avain = "f9463bc94dd7f584483b04a3a49f18ba";

            Console.WriteLine($"Aloitetaan säätietojen haku kaupungista {kaupunki}.");
            HttpClient client = new HttpClient();
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={kaupunki}&appid={avain}&units=metric";

            HttpResponseMessage vastaus = client.GetAsync(url).Result;
            string json = vastaus.Content.ReadAsStringAsync().Result;

            OpenWeatherApiSäätiedot tiedot =
                JsonSerializer.Deserialize<OpenWeatherApiSäätiedot>(json);

            Console.WriteLine($"Lämpötila kaupungissa {kaupunki} on: {tiedot.main.temp} °C.");
        }
    }
}
