using NUnit.Framework;
using ASP.NET_MVC_WeatherApp.Models;

namespace WeatherAppTests.Models
{
    public class OpenWeatherMapTests
    {
        [Test]
        public void OpenWeatherMap_PropertiesAreSet_Correctly()
        {
            // Arrange
            var openWeatherMap = new OpenWeatherMap
            {
                apiResponse = "Sample API Response",
                lat = "33.44",
                lon = "-94.04",
            };

            // Act and Assert
            Assert.AreEqual("Sample API Response", openWeatherMap.apiResponse);
            Assert.AreEqual("33.44", openWeatherMap.lat);
            Assert.AreEqual("-94.04", openWeatherMap.lon);
        }

        [Test]
        public void OpenWeatherMap_PropertiesAreSet_NullValues()
        {
            // Arrange
            var openWeatherMap = new OpenWeatherMap
            {
                apiResponse = null,
                lat = null,
                lon = null,
            };

            // Act and Assert
            Assert.IsNull(openWeatherMap.apiResponse);
            Assert.IsNull(openWeatherMap.lat);
            Assert.IsNull(openWeatherMap.lon);
        }

        // You can add more test cases as needed to cover various scenarios.
    }
}
