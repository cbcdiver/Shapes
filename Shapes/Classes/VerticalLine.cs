using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class VerticalLine : Line
    {
        public VerticalLine(int x = 0, int y = 0, int y2 = 0) : base(x, y, x, y2) { }

        override public void Draw()
        {
            Console.WriteLine("About to Draw a Vertical Line");
        }
    }
}
