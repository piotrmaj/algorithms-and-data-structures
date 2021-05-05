using System;
using Xunit;

namespace NumberToLCD.Tests
{
    public class MultiDigitNumberTest
    {
        [Fact]
        public void Test_100()
        {
            var actual = LCD.ToString(100);

            String expected = "    _  _ " + Environment.NewLine
                            + "  || || |" + Environment.NewLine
                            + "  ||_||_|";
            Assert.Equal(expected, actual);
        }
    }
}
