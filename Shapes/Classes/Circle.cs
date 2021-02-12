using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle: Oval
    {
        public Circle(int x = 0, int y = 0, int r = 0) : base(x, y, r, r) { }

        public override void Draw()
        {
            Console.WriteLine("About to Draw a Circle");
        }
    }
}
