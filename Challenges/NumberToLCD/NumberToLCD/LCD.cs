using System;
using System.Linq;

namespace NumberToLCD
{
    public class LCD
    {
        private static class Symbols
        {
            public static string Empty = "   ";
            public static string _ = " _ ";
            public static string lspacel = "| |";
            public static string U = "|_|";
            public static string SpaceSpaceI = "  |";
        }

        private int width;
        private int height;
        private string[] Lines;

        public LCD(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.Lines = new string[height * 2 + 1];
        }

        private void Add(int digit)
        {
            LCDElem elem = LCDElem.FromDigit(digit);
            var line = 0;
            Lines[line++] += $" {string.Join(string.Empty, Enumerable.Repeat(elem.HasTopLine ? "_" : " ", width))} ";

            for (int i = 1; i < height; i++)
            {
                Lines[line++] += $"{(elem.HasTopLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(" ", width))}{(elem.HasTopRight ? "|" : " ")}";
            }

            Lines[line++] += $"{(elem.HasTopLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(elem.HasMiddleLine ? "_" : " ", width))}{(elem.HasTopRight ? "|" : " ")}";
            for (int i = 1; i < height; i++)
            {
                Lines[line++] += $"{(elem.HasBottomLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(" ", width))}{(elem.HasBottomRight ? "|" : " ")}";
            }

            Lines[line++] += $"{(elem.HasBottomLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(elem.HasBottomLine ? "_" : " ", width))}{(elem.HasBottomRight ? "|" : " ")}";
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Lines);
        }

        public static String ToString(int number, int width = 1, int height = 1)
        {
            LCD lcd = new LCD(width, height);
            foreach (char c in number.ToString())
            {
                var digit = int.Parse(c.ToString());
                lcd.Add(digit);
            }

            return lcd.ToString();
        }
    }
}
