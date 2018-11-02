using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Interfaces;
using CSharpBasics.Classes;

namespace CSharpBasics.Abstracts
{
    public abstract  class Shape:IShape
    {
        public static IPoint[] Generate(int numberOfPoints)
        {
            IPoint[] points = new IPoint[numberOfPoints];
            Random random = new Random();
            int randomX = -1;
            int randomY = -1;
            for (int i = 0; i < numberOfPoints; i++)
            {
                randomX = random.Next(0, 100);
                randomY = random.Next(0, 100);
                points[i] = new XY_Point(randomX, randomY);
            }
            return points;
        }

       public IPoint[] Points
       {
           get;
           protected set;
       }

       public float Height
       {
           get { return getHeight(); }
       }

       public float Width
       {
           get { return getWidth(); }
       }

       public float Length
       {
           get { return getLength(); }
       }

       public virtual void Merge(IShape shape)
       {
           
       }

       public virtual string GetName()
       {
           return string.Format("{0} Points Shape", Points.Length);
       }


       private float getWidth()
       {
           int min = Points[0].X;
           int max = min;
           foreach (IPoint point in Points)
           {
               if (point.X > max) max = point.X;
               if (point.X < min) min = point.X;
           }
           return max - min;
       }
       private float getHeight()
       {
           int min = Points[0].Y;
           int max = min;
           foreach (IPoint point in Points)
           {
               if (point.Y > max) max = point.Y;
               if (point.Y < min) min = point.Y;
           }
           return max - min;
       }

       private float getLength()
       {
           float delta = 0;
           for (int i = 0; i < Points.Length;i++)
           {
               if (i + 1 == Points.Length)
               {
                   delta += (float)Math.Sqrt(Math.Pow((Points[0].X - Points[i].X) , 2) + Math.Pow((Points[0].Y - Points[i].Y) , 2));
               }
               else
               {
                   delta += (float)Math.Sqrt(Math.Pow((Points[i + 1].X - Points[i].X) , 2) + Math.Pow( (Points[i + 1].Y - Points[i].Y) , 2));
                   
               }
           }

           return delta;
       }
    }
}
