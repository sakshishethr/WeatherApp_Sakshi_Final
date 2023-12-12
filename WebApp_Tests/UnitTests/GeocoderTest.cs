using ASP.NET_MVC_WeatherApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using NUnit.Framework;

namespace WeatherAppTests.Models
{
    [TestFixture]
    public class GeocoderTests
    {
        [Test]
        public void Geocoder_PropertiesAreSet_Correctly()
        {
            // Arrange
            var geocoder = new Geocoder
            {
                lat = "33.44",
                lon = "-94.04",
                cityName = "YourCityName",
                countryCode = "YourCountryCode",
                stateCode = "YourStateCode",
                countries = new SelectList(new[] { "Country1", "Country2" }),
                states = new SelectList(new[] { "State1", "State2" }),
                cities = new SelectList(new[] { "City1", "City2" }),
            };

            // Act and Assert
            Assert.AreEqual("33.44", geocoder.lat);
            Assert.AreEqual("-94.04", geocoder.lon);
            Assert.AreEqual("YourCityName", geocoder.cityName);
            Assert.AreEqual("YourCountryCode", geocoder.countryCode);
            Assert.AreEqual("YourStateCode", geocoder.stateCode);
            Assert.IsNotNull(geocoder.countries);
            Assert.IsNotNull(geocoder.states);
            Assert.IsNotNull(geocoder.cities);
        }

        [Test]
        public void Geocoder_PropertiesAreSet_NullValues()
        {
            // Arrange
            var geocoder = new Geocoder
            {
                lat = null,
                lon = null,
                cityName = null,
                countryCode = null,
                stateCode = null,
                countries = null,
                states = null,
                cities = null,
            };

            // Act and Assert
            Assert.IsNull(geocoder.lat);
            Assert.IsNull(geocoder.lon);
            Assert.IsNull(geocoder.cityName);
            Assert.IsNull(geocoder.countryCode);
            Assert.IsNull(geocoder.stateCode);
            Assert.IsNull(geocoder.countries);
            Assert.IsNull(geocoder.states);
            Assert.IsNull(geocoder.cities);
        }

        // You can add more test cases as needed to cover various scenarios.
    }
}
