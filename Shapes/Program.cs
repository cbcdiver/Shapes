using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] arrayOfShapes = new Shape[10];
            Random rand = new Random();

            for (int number = 0; number < 10; number ++ )
            {
                int randomNumber = rand.Next(5);
                switch (randomNumber) {
                    case 0:
                        arrayOfShapes[number] = new Rect();
                        break;
                    case 1:
                        arrayOfShapes[number] = new Oval();
                        break;
                    case 2:
                        arrayOfShapes[number] = new Square();
                        break;
                    case 3:
                        arrayOfShapes[number] = new Circle();
                        break;
                    case 4:
                        arrayOfShapes[number] = new Line();
                        break;
                }
            }

            foreach (Shape aShape in arrayOfShapes)
            {
                aShape.Draw();
            }
        }
    }
}
