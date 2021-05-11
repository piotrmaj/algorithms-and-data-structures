using System.Collections.Generic;

namespace Yahtzee
{
    public interface IRule
    {
        public int CalculateScore(List<int> diceValues);
    }
}