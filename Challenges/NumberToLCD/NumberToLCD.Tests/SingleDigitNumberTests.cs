using System;
using Xunit;

namespace NumberToLCD.Tests
{
    public class SingleDigitNumberTests
    {
        [Fact]
        public void Test_digit_0()
        {
            var actual = LCD.ToString(0);

            String expected = " _ " + Environment.NewLine
                            + "| |" + Environment.NewLine
                            + "|_|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_0_width2()
        {
            var actual = LCD.ToString(0, 2);

            String expected = " __ " + Environment.NewLine
                            + "|  |" + Environment.NewLine
                            + "|__|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_0_height2()
        {
            var actual = LCD.ToString(0, 1, 2);

            String expected = " _ " + Environment.NewLine
                            + "| |" + Environment.NewLine
                            + "| |" + Environment.NewLine
                            + "| |" + Environment.NewLine
                            + "|_|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_1()
        {
            var actual = LCD.ToString(1);

            String expected = "   " + Environment.NewLine
                            + "  |" + Environment.NewLine
                            + "  |";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_2()
        {
            var actual = LCD.ToString(2);
            String expected = " _ " + Environment.NewLine
                            + " _|" + Environment.NewLine
                            + "|_ ";
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_digit_3()
        {
            var actual = LCD.ToString(3);
            String expected = " _ " + Environment.NewLine
                            + " _|" + Environment.NewLine
                            + " _|";
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void Test_digit_1()
        //{
        //    var actual = LCD.ToString(1);

        //    String expected = $"  {Environment.NewLine} |{Environment.NewLine} |";
        //    Assert.Equal(expected, actual);
        //}
    }
}
