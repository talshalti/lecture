using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Abstracts;

namespace CSharpBasics.Classes
{
   internal class XY_Point:Point,IComparable
    {
       public XY_Point(int x,int y):base(x,y)
       {
           Console.WriteLine("XY_Point Created X:{0},Y:{1}", this.X, this.Y);
       }

       #region Binary ops
       // overloaded operator +
       public static XY_Point operator +(XY_Point p1, XY_Point p2)
       { return new XY_Point(p1.X + p2.X, p1.Y + p2.Y); }

       // overloaded operator -
       public static XY_Point operator -(XY_Point p1, XY_Point p2)
       { return new XY_Point(p1.X - p2.X, p1.Y - p2.Y); }

       public static XY_Point operator +(XY_Point p1, int change)
       {
           return new XY_Point(p1.X + change, p1.Y + change);
       }

       public static XY_Point operator +(int change, XY_Point p1)
       {
           return new XY_Point(p1.X + change, p1.Y + change);
       }
       #endregion

       #region Unary ops
       // Add 1 to the X/Y values incoming Point.
       public static XY_Point operator ++(XY_Point p1)
       { return new XY_Point(p1.X + 1, p1.Y + 1); }

       // Subtract 1 from the X/Y values incoming Point.
       public static XY_Point operator --(XY_Point p1)
       { return new XY_Point(p1.X - 1, p1.Y - 1); }
       #endregion

       #region Equality logic
       public override bool Equals(object o)
       {
           return o.ToString() == this.ToString();
       }

       public override int GetHashCode()
       { return this.ToString().GetHashCode(); }

       // Now let's overload the == and != operators.
       public static bool operator ==(XY_Point p1, XY_Point p2)
       { return p1.Equals(p2); }

       public static bool operator !=(XY_Point p1, XY_Point p2)
       { return !p1.Equals(p2); }
       #endregion

       
    }
}
