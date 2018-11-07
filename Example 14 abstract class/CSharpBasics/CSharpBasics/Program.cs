using CSharpBasics.Abstracts;
using CSharpBasics.Classes;
using CSharpBasics.Exceptions;
using CSharpBasics.Interfaces;
using System;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Triangle");
            Triangle triangle = new Triangle(
                new XY_Point(10, 10),
                new XY_Point(20, 50),
                new XY_Point(30, 20));

            Console.WriteLine("Triangle Width:{0},Height:{1}", triangle.Width, triangle.Height);
            Console.WriteLine("Triangle Length:{0}", triangle.Length);

            //Polymorphism masking base method
            Rectangle rectangle = new Rectangle(20, 20, 60, 60);
            Console.WriteLine("Rectangle Width:{0},Height:{1}", rectangle.Width, rectangle.Height);
            Console.WriteLine("Rectangle Length:{0}", rectangle.Length);
            Console.WriteLine("Rectangle Shape Own Name:{0}", rectangle.GetName());
            // GetName Works because of override
            Console.WriteLine("Rectangle Shape Base Name:{0}", (rectangle as Shape).GetName());


            //Polymorphism calling base method
            Square square = new Square(20, 20, 60);
            Console.WriteLine("Square Width:{0},Height:{1}", square.Width, square.Height);
            Console.WriteLine("Square Shape Own Name:{0}", square.GetName());
            Rectangle rectangleFromSquare = (Rectangle)square;
            // GetName Works Doesn't work because of new
            Console.WriteLine("Square Shape Base Name:{0}", rectangleFromSquare.GetName());
            // Why new is needed?

            Console.WriteLine("Enter weird shape number of points:");
            string numberOfPoints = Console.ReadLine();
            int actualNumberOfPoints = 12;
            int.TryParse(numberOfPoints, out actualNumberOfPoints);

            IPoint[] wierdPoints = Shape.Generate(actualNumberOfPoints);
            WierdShape wierdShape = new WierdShape(wierdPoints);
            Console.WriteLine("WierdShape Name:{0}", wierdShape.GetName());
            Console.WriteLine("WierdShape Width:{0},Height:{1}", wierdShape.Width, wierdShape.Height);
            Console.WriteLine("WierdShape Length:{0}", wierdShape.Length);
            Console.WriteLine("Compare WeirdShape last 2 points:{0}", ((Point)wierdShape.Points[actualNumberOfPoints - 2]).CompareTo(wierdShape.Points.Last()));

            try
            {
                Triangle triangle2 = new Triangle(
               new XY_Point(10, 10),
               new XY_Point(20, 50),
               new XY_Point(30, 20),
               new XY_Point(30, 20));
            }
            catch (ShapeException ex)
            {
                Console.WriteLine(ex.Message + ":" + ex.Shape.GetName());
            }

            try
            {
                rectangle.Merge(triangle);
            }
            catch (ShapeException ex)
            {
                Console.WriteLine("Merge exception {0}, Tried merging with:{1}", ex.Message, ex.Shape.GetName());
            }
            catch (Exception ex)
            {
                throw;
            }

            Console.Read();
        }

    }
}
