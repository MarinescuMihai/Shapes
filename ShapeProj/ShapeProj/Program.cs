using ShapeProj.Shapes;
using System;
using System.Collections.Generic;

namespace ShapeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>()
            {
                new Circle(),
                new Triangle(),
                new Square()
            };

            foreach (var shape in shapeList)
            {
                Console.WriteLine(shape.ShowTheAriaFormula());
            }

            Console.ReadKey();
        }
    }
}
