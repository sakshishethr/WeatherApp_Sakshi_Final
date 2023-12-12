using System;
using System.Net.Http;
using System.Threading.Tasks;
using ASP.NET_MVC_WeatherApp.Controllers;
using ASP.NET_MVC_WeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace WeatherAppTests
{
    public class OpenWeatherMapControllerTests
    {
        private OpenWeatherMapController _controller;
        private HttpClient _httpClient;

        [SetUp]
        public void Setup()
        {
            // Initialize your controller and HttpClient here
            _controller = new OpenWeatherMapController();
            _httpClient = new HttpClient();
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of HttpClient and clean up any resources if needed
            _httpClient.Dispose();
        }

        [Test]
        public async Task ConvertGeocode_ValidInput_ReturnsGeocoder()
        {
            // Arrange
            string cityName = "CityName";
            string stateCode = "StateCode";
            string countryCode = "CountryCode";

            // Act
            var result = await _controller.ConvertGeocode(cityName, stateCode, countryCode);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<Geocoder>(result);
        }

        [Test]
        public async Task GetWeather_ValidInput_ReturnsRedirectToActionResult()
        {
            // Arrange
            string cityName = "CityName";
            string stateCode = "StateCode";
            string countryCode = "CountryCode";

            // Act
            var result = await _controller.GetWeather(cityName, stateCode, countryCode);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public async Task GetWeather_InvalidInput_ReturnsViewResult()
        {
            // Arrange
            string cityName = null; // Invalid input

            // Act
            var result = await _controller.GetWeather(cityName, null, null);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
