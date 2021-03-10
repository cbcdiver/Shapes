using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Line : Shape
    {
        public int x2 { get; set; }
        public int y2 { get; set; }

        public Line(int x = 0, int y = 0, int x2 = 0, int y2 = 0) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
        }

        override public double Area()
        {
            return 0.0;
        }

        override public void Draw()
        {
            Console.WriteLine("About to Draw a Line");
        }
    }
}
