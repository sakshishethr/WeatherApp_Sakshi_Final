using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_MVC_WeatherApp.Models
{
    // This is the Geocoder class representing geolocation data
    // Author: Sakshi
    // Student Number: A00262877
    public class Geocoder
    {
        public string lat { get; set; }
        public string lon { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string stateCode { get; set; }
        public SelectList countries { get; set; }
        public SelectList states { get; set; }
        public SelectList cities { get; set; }
    }
}
