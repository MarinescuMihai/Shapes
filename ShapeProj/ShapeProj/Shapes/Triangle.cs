using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine($"area of triangle is calculated using this {FormulaForShapeArea}");
        }
    }
}
