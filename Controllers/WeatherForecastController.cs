using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DockerizedProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }




        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            return new List<WeatherForecast>()
            {
                new(){Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Sunny"},    
                new(){Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Sunny"},    
                new(){Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Sunny"},    
                new(){Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Sunny"},    
                new(){Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Sunny"},    
            };
            //    var forecasts = new List<WeatherForecast>();

            //    var connStr = _configuration.GetConnectionString("DefaultConnection");
            //    using var conn = new SqlConnection(connStr);
            //    conn.Open();

            //    // Tablo yoksa olu?tur
            //    var createTableCmd = new SqlCommand(@"
            //IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='WeatherForecasts' AND xtype='U')
            //CREATE TABLE WeatherForecasts (
            //    Date date PRIMARY KEY,
            //    TemperatureC int,
            //    Summary nvarchar(50)
            //)", conn);
            //    createTableCmd.ExecuteNonQuery();

            //    // Tablo bo?sa örnek veri ekle
            //    var checkDataCmd = new SqlCommand("SELECT COUNT(*) FROM WeatherForecasts", conn);
            //    int rowCount = (int)checkDataCmd.ExecuteScalar();

            //    if (rowCount == 0)
            //    {
            //        var insertCmd = new SqlCommand(@"
            //    INSERT INTO WeatherForecasts (Date, TemperatureC, Summary) VALUES
            //    (CAST(GETDATE() AS date), 25, 'Sunny'),
            //    (DATEADD(day, 1, CAST(GETDATE() AS date)), 18, 'Cloudy'),
            //    (DATEADD(day, 2, CAST(GETDATE() AS date)), 30, 'Hot'),
            //    (DATEADD(day, 3, CAST(GETDATE() AS date)), 10, 'Cold'),
            //    (DATEADD(day, 4, CAST(GETDATE() AS date)), 22, 'Warm')", conn);
            //        insertCmd.ExecuteNonQuery();
            //    }

            //    // Verileri oku ve döndür
            //    var selectCmd = new SqlCommand("SELECT TOP 5 Date, TemperatureC, Summary FROM WeatherForecasts ORDER BY Date", conn);
            //    using var reader = selectCmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        forecasts.Add(new WeatherForecast
            //        {
            //            Date = DateOnly.FromDateTime(reader.GetDateTime(0)),
            //            TemperatureC = reader.GetInt32(1),
            //            Summary = reader.GetString(2)
            //        });
            //    }

            //    return forecasts;
        }

    }
}
