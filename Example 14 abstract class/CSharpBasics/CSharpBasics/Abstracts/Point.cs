using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Interfaces;

namespace CSharpBasics.Abstracts
{
   abstract class Point:IPoint,IComparable
    {
       public Point(int x, int y)
       {
           X = x;
           Y = y;
       }

       public int X
       {
           get;
           set;
       }

       public int Y
       {
           get;
           set;
       }

       #region Compare ops
       public int CompareTo(object obj)
       {
           if (obj is Point)
           {
               Point p = (Point)obj;
               if (this.X > p.X && this.Y > p.Y)
                   return 1;
               if (this.X < p.X && this.Y < p.Y)
                   return -1;
               else
                   return 0;
           }
           else
               throw new ArgumentException();
       }

       public static bool operator <(Point p1, Point p2)
       { return (p1.CompareTo(p2) < 0); }

       public static bool operator >(Point p1, Point p2)
       { return (p1.CompareTo(p2) > 0); }

       public static bool operator <=(Point p1, Point p2)
       { return (p1.CompareTo(p2) <= 0); }

       public static bool operator >=(Point p1, Point p2)
       { return (p1.CompareTo(p2) >= 0); }

       #endregion

      
    }
}
