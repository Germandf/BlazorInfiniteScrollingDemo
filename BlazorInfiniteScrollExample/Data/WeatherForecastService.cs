namespace BlazorInfiniteScrollExample.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<WeatherForecast>> GetForecastAsync()
        {
            var weatherForecasts = new List<WeatherForecast>();
            for (int i = 0; i < 1000; i++)
            {
                weatherForecasts.Add(new()
                {
                    Id = i,
                    Date = DateTime.Today,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });
            }
            return Task.FromResult(weatherForecasts);
        }
    }
}