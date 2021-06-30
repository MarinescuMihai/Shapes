using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Square : Shape
    {
        public Square()
        {
            FormulaForShapeArea = "a^2";
        }
        public override string ShowTheAriaFormula()
        {
            return $"Area of Square is calculated using this {FormulaForShapeArea}";
        }
    }
}
