using Xunit;

namespace Bowling.Test
{
    public class BowlingServiceTests
    {
        private BowlingService service;
        public BowlingServiceTests()
        {
            service = new BowlingService();
        }

        [Theory]
        [InlineData("X X X X X X X X X X X X", 300)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150)]
        [InlineData("53 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 143)]
        [InlineData("53 21 21 21 22 33 44 81 9- --", 53)]
        public void Test1(string input, int expectedResult)
        {
            Assert.Equal(expectedResult, service.CalculateScore(input));
        }
    }
}