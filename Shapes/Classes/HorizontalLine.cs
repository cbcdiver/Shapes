using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class HorizontalLine : Line
    {
        public HorizontalLine(int x = 0, int y = 0, int x2 = 0) : base(x, y, x2, y) { }

        override public void Draw()
        {
            Console.WriteLine("About to Draw a Horizontal Line");
        }
    }
}
