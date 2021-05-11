using System;
using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class PairRule: IRule
    {
        public int CalculateScore(List<int> diceValues)
        {
            var score = 0;
            for (int i = Consts.DiceMinValue; i <= Consts.DiceMaxValue; i++)
            {
                if (diceValues.Count(x => x == i) >= 2)
                {
                    score = Math.Max(2 * i, score);
                }
            }

            return score;
        }
    }
}