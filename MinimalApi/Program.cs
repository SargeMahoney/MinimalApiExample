using MinimalApi.Api.StringApi;
using MinimalApi.Api.WeatherApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


WeatherApiConfigurator.WeatherApiConfig(app);
ExampleStringApi.StringApiConfig(app);

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}