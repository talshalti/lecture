using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics.Classes
{
    class Square:Rectangle
    {
        public Square(int x, int y, int length):base(x,y,length,length) { }

        public new string GetName()
        {
            return "Square";
        }
    }
}
