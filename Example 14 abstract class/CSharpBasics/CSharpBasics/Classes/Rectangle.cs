using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Abstracts;
using CSharpBasics.Interfaces;
using CSharpBasics.Exceptions;

namespace CSharpBasics.Classes
{
   public class Rectangle:Shape
    {
        public Rectangle(int X,int Y,int Width,int Height)
        {
            IPoint[] points = new XY_Point[4];
            points[0] = new XY_Point(X, Y);
            points[1] = new XY_Point(X+Width, Y);
            points[2] = new XY_Point(X+Width, Y+Height);
            points[3] = new XY_Point(X, Y+Height);
            Points = points;
        }

        public override void Merge(Interfaces.IShape shape)
        {
            if (!(shape is Rectangle))
            {
                throw new ShapeException("Rectangle cannot be merged with other shapes", shape);
            }
        }

        public override string GetName()
        {
            return "Rectangle";
        }

        
    }
}
