using CSharpBasics.Interfaces;
using System;

namespace CSharpBasics.Exceptions
{
    class ShapeException : Exception
    {
        public IShape Shape { get; set; }
        public ShapeException(string data, IShape shape) : base(data)
        {
            this.Shape = shape;
        }
    }
}
