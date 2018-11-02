using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Abstracts;
using CSharpBasics.Interfaces;

namespace CSharpBasics.Classes
{
    class WierdShape:Shape
    {
        public WierdShape(params IPoint[] points)
       {
            Points = points;
        }
    }
}
