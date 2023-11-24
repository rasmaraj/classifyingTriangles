using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classifyingTriangles.Component.Interaces
{
   public interface ITriangleType
    {
        string GetTriangleType(double side1,double side2,double side3);
    }
}
