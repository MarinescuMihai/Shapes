using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Triangle : Shape
    {
        public Triangle()
        {
            FormulaForShapeArea = "(AB*CD)/2";
        }

        public override string ShowTheAriaFormula()
        {
            return $"Area of Triangle is calculated using this {FormulaForShapeArea}";
        }
    }
}
