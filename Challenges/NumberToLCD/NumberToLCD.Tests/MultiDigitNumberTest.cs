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

        [Fact]
        public void Test_456_width2_height2()
        {
            var actual = LCD.ToString(456, 2, 2);

            String expected = "     __  __ " + Environment.NewLine
                            + "|  ||   |   " + Environment.NewLine
                            + "|__||__ |__ " + Environment.NewLine
                            + "   |   ||  |" + Environment.NewLine
                            + "   | __||__|";
            Assert.Equal(expected, actual);
        }
    }
}
