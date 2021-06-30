using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj
{
    public class Shape : IFormula
    {
        public string FormulaForShapeArea { get ; set;}

        public virtual void CalculateArea()
        {

        }
    }
}
