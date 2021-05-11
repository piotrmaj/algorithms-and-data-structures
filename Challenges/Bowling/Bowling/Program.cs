using System;
using System.Collections.Generic;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-";
            var pairs = new List<GameSequence>();
            foreach (var pair in input.Split(" "))
            {
                var val1 = RollValueParser.Parse(pair[0]);
                var val2 = RollValue.Zero;
                if (val1 != RollValue.Strike)
                {
                    val2 = RollValueParser.Parse(pair[1]);
                }
                pairs.Add(new GameSequence
                {
                    Val1 = val1,
                    Val2 = val2
                });
            }

            var sc = new ScoreCalculator();
            var result = sc.Calculate(pairs);

            Console.WriteLine("Hello World!");
        }
    }
}
