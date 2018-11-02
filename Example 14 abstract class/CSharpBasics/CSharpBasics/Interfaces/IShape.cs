using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics.Interfaces
{
    public interface IShape
    {
        IPoint[] Points { get;  }
        float Height { get;  }
        float Width { get;  }
        float Length { get; }
        void Merge(IShape shape);
        string GetName();
    }
}
