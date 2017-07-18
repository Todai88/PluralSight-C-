using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Triangle : AbstractRegularPolygon, IDisposable
    {
        public Triangle(int length) :
            base(3, length)
        {

        }

        public override double GetArea()
        {
            return (SideLength * SideLength * Math.Sqrt(3)) / 4;
        }

        public void Dispose()
        { 
            GC.SuppressFinalize(this);
        }
    }
}
