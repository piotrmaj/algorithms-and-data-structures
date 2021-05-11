using System.Collections.Generic;

namespace Bowling
{
    public class BowlingService
    {
        private readonly ScoreCalculator _scoreCalculator = new ScoreCalculator();

        public int CalculateScore(string input)
        {
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
                    Val2 = val2,
                    Val3 = pair.Length > 2 ? RollValueParser.Parse(pair[2]) : 0,
                });
            }

            return _scoreCalculator.Calculate(pairs);
        }
    }
}