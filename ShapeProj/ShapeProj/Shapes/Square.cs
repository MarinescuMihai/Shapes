using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Square : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine($"area of square is calculated using this {FormulaForShapeArea}");
        }
    }
}
