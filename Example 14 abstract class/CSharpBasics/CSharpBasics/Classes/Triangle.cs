﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics.Abstracts;
using CSharpBasics.Interfaces;
using CSharpBasics.Exceptions;

namespace CSharpBasics.Classes
{
   public class Triangle:Shape
    {
      
       // This constructor can get N parameters
       public Triangle(params IPoint[] points)
       {
           if (points.Length != 3) throw new ShapeException("Wrong number of points:" + points.Length, this);
           if ((Point)points[0] >= (Point)points[1] || (Point)points[0] >= (Point)points[2])
           {
               throw new ShapeException("Triangle is invalid", this);
           }
           Points = points;
       }

       public override string GetName()
       {
           return "Triangle";
       }

       
    }
}
