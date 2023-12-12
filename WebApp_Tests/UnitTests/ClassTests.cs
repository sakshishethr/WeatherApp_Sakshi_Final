using NUnit.Framework;
using WeatherApp_Sakshi_WebDev.Class;

namespace WeatherAppTests
{
    public class LocalNamesTests
    {
        [Test]
        public void LocalNames_PropertiesAreSet_Correctly()
        {
            // Arrange
            var localNames = new LocalNames
            {
                ms = "Malay",
                gu = "Gujarati",
                // Set other properties as needed
            };

            // Act and Assert
            Assert.AreEqual("Malay", localNames.ms);
            Assert.AreEqual("Gujarati", localNames.gu);
            // Assert other properties as needed
        }

        [Test]
        public void Alert_PropertiesAreSet_Correctly()
        {
            // Arrange
            var alert = new Alert
            {
                sender_name = "Sender",
                @event = "Event",
                // Set other properties as needed
            };

            // Act and Assert
            Assert.AreEqual("Sender", alert.sender_name);
            Assert.AreEqual("Event", alert.@event);
            // Assert other properties as needed
        }

        [Test]
        public void Current_PropertiesAreSet_Correctly()
        {
            // Arrange
            var current = new Current
            {
                dt = 123456,
                temp = 25.5,
                // Set other properties as needed
            };

            // Act and Assert
            Assert.AreEqual(123456, current.dt);
            Assert.AreEqual(25.5, current.temp);
            // Assert other properties as needed
        }

        [Test]
        public void Daily_PropertiesAreSet_Correctly()
        {
            // Arrange
            var daily = new Daily
            {
                dt = 123456,
                moonrise = 789012,
                // Set other properties as needed
            };

            // Act and Assert
            Assert.AreEqual(123456, daily.dt);
            Assert.AreEqual(789012, daily.moonrise);
            // Assert other properties as needed
        }
    }
}
