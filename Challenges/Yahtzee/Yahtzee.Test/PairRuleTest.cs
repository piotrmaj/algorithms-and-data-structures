using System.Linq;
using Xunit;

namespace Yahtzee.Test
{
    public class PairRuleTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 4, 5, 6 }, 0)]
        [InlineData(new int[] { 1, 2, 2, 5, 5 }, 10)]
        [InlineData(new int[] { 1, 1, 2, 5, 5 }, 10)]
        [InlineData(new int[] { 1, 1, 2, 4, 5 }, 2)]
        [InlineData(new int[] { 5, 5, 5, 6, 6 }, 12)]
        public void DifferentPairs(int[] diceValues, int expectedScore)
        {
            var rule = new PairRule();
            var actual = rule.CalculateScore(diceValues.ToList());

            Assert.Equal(expectedScore, actual);
        }
    }
}