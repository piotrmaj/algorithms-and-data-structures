using System.Collections.Generic;

namespace Bowling
{
    public class ScoreCalculator
    {
        public int Calculate(List<GameSequence> input)
        {
            var score = 0;
            for (int i = 9; i >= 0 ; i--)
            {
                var nextTwoRollsScore = 0;
                var nextRollScore = (i == input.Count - 1) ? (int)input[i].Val3 : (int)input[i + 1].Val1;

                if (i == input.Count - 2)
                {
                    nextTwoRollsScore += nextRollScore + (int)input[i + 1].Val2;
                } else if (i < input.Count - 2)
                {
                    if (input[i + 1].Val1 == RollValue.Strike)
                    {
                        nextTwoRollsScore += nextRollScore + (int)input[i + 2].Val1;
                    }
                    else
                    {
                        nextTwoRollsScore += nextRollScore + (int)input[i + 1].Val2;
                    }
                }

                if (input[i].Val1 == RollValue.Strike)
                {
                    score += (int)input[i].Val1;
                    score += nextTwoRollsScore;
                } else if (input[i].Val2 == RollValue.Spare)
                {
                    score += (int)input[i].Val2;
                    score += nextRollScore;
                }
                else
                {
                    score += (int)input[i].Val1 + (int)input[i].Val2;
                }
            }
            return score;
        }
    }
}