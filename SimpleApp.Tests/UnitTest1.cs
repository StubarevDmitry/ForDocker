
using Microsoft.VisualStudio.TestPlatform.TestHost;
using SimpleApp;
using Xunit;

namespace SimpleApp.Tests
{
    public class SimpleServiceTests
    {
        [Fact]
        public void PlusOne_ShouldReturnIncrementedValue()
        {
            // Arrange
            int input = 5;
            int expected = 6;

            // Act
            int result = ForTest.plusOne(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(10, 11)]
        [InlineData(-5, -4)]
        public void PlusOne_ShouldHandleVariousInputs(int input, int expected)
        {
            // Act
            int result = ForTest.plusOne(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
