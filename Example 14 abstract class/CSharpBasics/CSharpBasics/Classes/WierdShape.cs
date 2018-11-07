using CSharpBasics.Abstracts;
using CSharpBasics.Interfaces;

namespace CSharpBasics.Classes
{
    class WierdShape : Shape
    {
        public WierdShape(params IPoint[] points)
        {
            Points = points;
        }
    }
}
