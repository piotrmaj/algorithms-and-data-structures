namespace Bowling
{
    public class GameSequence
    {
        public RollValue Val1 { get; set; }
        public RollValue Val2 { get; set; }
        public RollValue Val3 { get; set; }

        public int NumberOfRolls
        {
            get
            {
                if (Val1 == RollValue.Strike)
                {
                    return 1;
                }
                return 2;
            }
        }
    }
}