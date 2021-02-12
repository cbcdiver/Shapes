using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rect:Shape
    {
        public int length { get; set; }
        public  int width { get; set; }

        public Rect(int x = 0, int y = 0, int length = 0, int width = 0): base(x, y)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.width = width;
        }

        override public double Area()
        {
            return x * y;
        }

        override public void Draw()
        {
            Console.WriteLine("About to Draw a Rect");
        }
    }
}
