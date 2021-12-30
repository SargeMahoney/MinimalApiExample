namespace MinimalApi.Api.WeatherApi
{
    public static class WeatherApiConfigurator
    {
        public static List<string> summaries = new List<string>()
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public static void WeatherApiConfig(this WebApplication app)
        {
            app.MapGet("/weatherforecast", () =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                   new WeatherForecast
                   (
                       DateTime.Now.AddDays(index),
                       Random.Shared.Next(-20, 55),
                       summaries[Random.Shared.Next(summaries.Count)]
                   ))
                    .ToArray();
                return forecast;
            });
        }
    }
}
