using System;
using System.Linq;

namespace NumberToLCD
{
    public class LCD
    {
        private readonly int width;
        private readonly int height;
        private readonly string[] lines;

        public LCD(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.lines = new string[height * 2 + 1];
        }

        private void Add(int digit)
        {
            LCDElem elem = LCDElem.FromDigit(digit);
            var line = 0;
            lines[line++] += $" {string.Join(string.Empty, Enumerable.Repeat(elem.HasTopLine ? "_" : " ", width))} ";

            for (int i = 1; i < height; i++)
            {
                lines[line++] += $"{(elem.HasTopLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(" ", width))}{(elem.HasTopRight ? "|" : " ")}";
            }

            lines[line++] += $"{(elem.HasTopLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(elem.HasMiddleLine ? "_" : " ", width))}{(elem.HasTopRight ? "|" : " ")}";
            for (int i = 1; i < height; i++)
            {
                lines[line++] += $"{(elem.HasBottomLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(" ", width))}{(elem.HasBottomRight ? "|" : " ")}";
            }

            lines[line++] += $"{(elem.HasBottomLeft ? "|" : " ")}{string.Join(string.Empty, Enumerable.Repeat(elem.HasBottomLine ? "_" : " ", width))}{(elem.HasBottomRight ? "|" : " ")}";
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, lines);
        }

        public static String ToString(int number, int width = 1, int height = 1)
        {
            LCD lcd = new LCD(width, height);
            foreach (char digitAsChar in number.ToString())
            {
                var digit = int.Parse(digitAsChar.ToString());
                lcd.Add(digit);
            }

            return lcd.ToString();
        }
    }
}
