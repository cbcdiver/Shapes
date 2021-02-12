using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Oval : Shape
    {
        public float r1 { get; set; }
        public float r2 { get; set; }

        public Oval(int x=0, int y=0, float r1=0, float r2=0): base (x ,y)
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        override public double Area()
        {
            return Math.PI * this.r1 * this.r2;
        }

        public override void Draw()
        {
            Console.WriteLine("About to Draw an Oval");
        }
    }
}
