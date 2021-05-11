using System.Collections.Generic;

namespace Bowling
{
    public class ScoreCalculator
    {
        private static int SequenceCount = 10;

        public int Calculate(List<GameSequence> input)
        {
            var score = 0;
            for (int i = SequenceCount - 1; i >= 0 ; i--)
            {
                var nextTwoRollsScore = 0;
                var isLastElement = i == input.Count - 1;
                var currentPair = input[i];
                var nextPair = !isLastElement ? input[i + 1] : null;
                var nextRollScore = !isLastElement ? (int)nextPair.Val1 : (int)currentPair.Val3;

                var isSecondLastElement = i == input.Count - 2;
                if (isSecondLastElement)
                {
                    nextTwoRollsScore += nextRollScore + (int)nextPair.Val2;
                } else if (i < input.Count - 2)
                {
                    if (nextPair.Val1 == RollValue.Strike)
                    {
                        nextTwoRollsScore += nextRollScore + (int)input[i + 2].Val1;
                    }
                    else
                    {
                        nextTwoRollsScore += nextRollScore + (int)nextPair.Val2;
                    }
                }

                if (currentPair.Val1 == RollValue.Strike)
                {
                    score += (int)RollValue.Strike;
                    score += nextTwoRollsScore;
                } else if (input[i].Val2 == RollValue.Spare)
                {
                    score += (int)RollValue.Spare;
                    score += nextRollScore;
                }
                else
                {
                    score += (int)currentPair.Val1 + (int)currentPair.Val2;
                }
            }
            return score;
        }
    }
}