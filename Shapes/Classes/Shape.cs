using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public Shape(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
    
        abstract public double Area();
        abstract public void Draw();
    }
}
