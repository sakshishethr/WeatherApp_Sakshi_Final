using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using ASP.NET_MVC_WeatherApp;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace WeatherAppTests.IntegrationTests
{
    [TestFixture]
    public class WeatherViewIntegrationTests
    {
        private HttpClient _client;
        private TestServer _server;

        [SetUp]
        public void SetUp()
        {
            // Create a TestServer with your application's assembly
            _server = new TestServer(new WebHostBuilder().UseStartup<Program>());
            _client = _server.CreateClient();
        }

        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
            _server.Dispose();
        }

        [Test]
        public async Task GetWeatherView_ReturnsSuccessStatusCode()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync("/OpenWeatherMap/GetWeather");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Test]
        public async Task GetWeatherView_ContainsExpectedContent()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync("/OpenWeatherMap/GetWeather");
            var content = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.IsTrue(content.Contains("<h1>Get Forecast</h1>"));
            Assert.IsTrue(content.Contains("Please select one"));
            Assert.AreEqual("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}
