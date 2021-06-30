using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj.Shapes
{
    class Circle : Shape
    {

        public Circle()
        {
            FormulaForShapeArea = "π R^2";
        }

        public override string ShowTheAriaFormula()
        {
            return $"Area of Circle is calculated using this {FormulaForShapeArea}";
        }
    }
}
