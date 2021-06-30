using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProj
{
    public abstract class Shape
    {
        protected virtual string FormulaForShapeArea { get ; set;}

        public virtual string ShowTheAriaFormula()
        {
            return string.Empty;
        }
    }
}
