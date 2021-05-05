using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToLCD
{
    public class LCDElem
    {
        public bool HasTopLine { get; set; }
        public bool HasTopLeft { get; set; }
        public bool HasTopRight { get; set; }
        public bool HasMiddleLine { get; set; }
        public bool HasBottomLeft { get; set; }
        public bool HasBottomRight { get; set; }
        public bool HasBottomLine { get; set; }

        private LCDElem(bool hasTopLine, bool hasTopLeft, bool hasTopRight, bool hasMiddleLine, bool hasBottomLeft, bool hasBottomRight, bool hasBottomLine)
        {
            HasTopLine = hasTopLine;
            HasTopLeft = hasTopLeft;
            HasTopRight = hasTopRight;
            HasMiddleLine = hasMiddleLine;
            HasBottomLeft = hasBottomLeft;
            HasBottomRight = hasBottomRight;
            HasBottomLine = hasBottomLine;
        }

        public static LCDElem FromDigit(int digit)
        {
            switch (digit)
            {
                case 0: return new LCDElem(true, true, true, false, true, true, true);
                case 1: return new LCDElem(false, false, true, false, false, true, false);
                case 2: return new LCDElem(true, false, true, true, true, false, true);
                case 3: return new LCDElem(true, false, true, true, false, true, true);
            }
            return null;
        }
    }
}
