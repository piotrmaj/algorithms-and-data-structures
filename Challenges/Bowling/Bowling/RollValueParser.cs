namespace Bowling
{
    public static class RollValueParser
    {
        public static RollValue Parse(char input)
        {
            switch (input)
            {
                case 'X': return RollValue.Strike;
                case '/': return RollValue.Spare;
                case '-': return RollValue.Zero;
                default: return (RollValue)int.Parse(input.ToString());
            }
        }
    }
}