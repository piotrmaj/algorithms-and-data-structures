using System;

namespace NumberToLCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(LCD.ToString(456, 2, 2));
            Console.ReadKey();
        }
    }
}
