using Newtonsoft.Json.Linq;

namespace WPiAA.Facade
{
    internal class Weather
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public Weather(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/")
            };
        }

        public async Task GetWeatherFrom(string city)
        {
            try
            {
                string requestUrl = $"weather?q={city}&units=metric&appid={_apiKey}";

                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var weatherData = JObject.Parse(responseBody);
                    double temperature = weatherData["main"]["temp"].Value<double>();

                    Console.WriteLine($"Aktualna temperatura w mieście {city} wynosi {temperature}°C.");
                }
                else
                {
                    Console.WriteLine($"Błąd: Nie udało się pobrać danych dla miasta {city}. Kod odpowiedzi: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }
    }
}