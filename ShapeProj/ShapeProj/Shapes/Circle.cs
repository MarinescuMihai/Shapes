using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine($"area of circle is calculated using this {FormulaForShapeArea}");
        }
    }
}
