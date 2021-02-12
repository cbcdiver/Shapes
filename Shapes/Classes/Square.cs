using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Rect
    {
        public Square(int x = 0, int y = 0, int size = 0) : base(x, y, size, size) {}

        public override void Draw()
        {
            Console.WriteLine("About to Draw a Square");
        }
    }
}
