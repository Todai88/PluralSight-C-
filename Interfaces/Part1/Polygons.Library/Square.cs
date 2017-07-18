using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Square : ConcreteRegularPolygon, IDisposable
    {
        public Square(int length) :
            base(4, length)
        {
            
        }

        public void Dispose()
        { 
            GC.SuppressFinalize(this);
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
