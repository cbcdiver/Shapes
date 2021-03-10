using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class LineSegments
    {
        public List<Line> theList = new List<Line>();
        public LineSegments() {}
        
        public void addASegment(Line lineToAdd)
        {
            if ( this.theList.Count == 0 ) {
                theList.Add(lineToAdd);
            }
            else
            {
                Line lastItem = this.theList[this.theList.Count - 1];
                if (( lastItem.x2 == lineToAdd.x )
                    && ( lastItem.y2 == lineToAdd.y))
                {
                    theList.Add(lineToAdd);
                }
                else
                {
                    Console.WriteLine("Can not add line!");
                }
            }
        }
    }
}
