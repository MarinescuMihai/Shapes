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
                new Circle(){ FormulaForShapeArea =  "π R^2"},
                new Triangle(){ FormulaForShapeArea = "(AB*CD)/2"},
                new Square(){ FormulaForShapeArea = "a^2"}
            };

            foreach (var shape in shapeList)
            {
                shape.CalculateArea();
            }

            Console.ReadKey();
        }
    }
}
