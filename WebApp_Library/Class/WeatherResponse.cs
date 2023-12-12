namespace WeatherApp_Sakshi_WebDev.Class
{

    // This is the Alert class representing weather alerts

    public class Alert
	{
		public string sender_name { get; set; }
		public string @event { get; set; }
		public int start { get; set; }
		public int end { get; set; }
		public string description { get; set; }
		public List<object> tags { get; set; }
	}
    // This is the Current class representing current weather data

    public class Current
	{
		public int dt { get; set; }
		public int sunrise { get; set; }
		public int sunset { get; set; }
		public double temp { get; set; }
		public double feels_like { get; set; }
		public int pressure { get; set; }
		public int humidity { get; set; }
		public double dew_point { get; set; }
		public double uvi { get; set; }
		public int clouds { get; set; }
		public int visibility { get; set; }
		public double wind_speed { get; set; }
		public int wind_deg { get; set; }
		public double wind_gust { get; set; }
		public List<Weather> weather { get; set; }
	}
    // This is the Daily class representing daily weather data

    public class Daily
	{
		public int dt { get; set; }
		public int sunrise { get; set; }
		public int sunset { get; set; }
		public int moonrise { get; set; }
		public int moonset { get; set; }
		public double moon_phase { get; set; }
		public string summary { get; set; }
		public Temp temp { get; set; }
		public FeelsLike feels_like { get; set; }
		public int pressure { get; set; }
		public int humidity { get; set; }
		public double dew_point { get; set; }
		public double wind_speed { get; set; }
		public int wind_deg { get; set; }
		public double wind_gust { get; set; }
		public List<Weather> weather { get; set; }
		public int clouds { get; set; }
		public double pop { get; set; }
		public double rain { get; set; }
		public double uvi { get; set; }
	}
    // This is the FeelsLike class representing feels-like temperature

    public class FeelsLike
	{
		public double day { get; set; }
		public double night { get; set; }
		public double eve { get; set; }
		public double morn { get; set; }
	}
  // This is the Hourly class representing hourly weather data

	public class Hourly
	{
		public int dt { get; set; }
		public double temp { get; set; }
		public double feels_like { get; set; }
		public int pressure { get; set; }
		public int humidity { get; set; }
		public double dew_point { get; set; }
		public int uvi { get; set; }
		public int clouds { get; set; }
		public int visibility { get; set; }
		public double wind_speed { get; set; }
		public int wind_deg { get; set; }
		public double wind_gust { get; set; }
		public List<Weather> weather { get; set; }
		public double pop { get; set; }
	}
    // This is the Minutely class representing minutely weather data

    public class Minutely
	{
		public int dt { get; set; }
		public int precipitation { get; set; }
	}
    // This is the Root class representing the root object containing weather data

    public class Root
	{
		public double lat { get; set; }
		public double lon { get; set; }
		public string timezone { get; set; }
		public int timezone_offset { get; set; }
		public Current current { get; set; }
		public List<Minutely> minutely { get; set; }
		public List<Hourly> hourly { get; set; }
		public List<Daily> daily { get; set; }
		public List<Alert> alerts { get; set; }
	}
    // This is the Temp class representing temperature data

    public class Temp
	{
		public double day { get; set; }
		public double min { get; set; }
		public double max { get; set; }
		public double night { get; set; }
		public double eve { get; set; }
		public double morn { get; set; }
	}
    // This is the Weather class representing weather information

    public class Weather
	{
		public int id { get; set; }
		public string main { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
	}


}
