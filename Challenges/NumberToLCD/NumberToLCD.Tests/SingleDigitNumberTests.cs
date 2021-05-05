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


        [Fact]
        public void Test_digit_4()
        {
            var actual = LCD.ToString(4);
            String expected = "   " + Environment.NewLine
                            + "|_|" + Environment.NewLine
                            + "  |";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_5()
        {
            var actual = LCD.ToString(5);
            String expected = " _ " + Environment.NewLine
                            + "|_ " + Environment.NewLine
                            + " _|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_6()
        {
            var actual = LCD.ToString(6);
            String expected = " _ " + Environment.NewLine
                            + "|_ " + Environment.NewLine
                            + "|_|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_7()
        {
            var actual = LCD.ToString(7);
            String expected = " _ " + Environment.NewLine
                            + "  |" + Environment.NewLine
                            + "  |";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_8()
        {
            var actual = LCD.ToString(8);
            String expected = " _ " + Environment.NewLine
                            + "|_|" + Environment.NewLine
                            + "|_|";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_digit_9()
        {
            var actual = LCD.ToString(9);
            String expected = " _ " + Environment.NewLine
                            + "|_|" + Environment.NewLine
                            + " _|";
            Assert.Equal(expected, actual);
        }
    }
}
