using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classifyingTriangles.Component.BLL
{
    public class TriangleTypeDetector : Interaces.ITriangleType
    {
        public string GetTriangleType(double side1,double side2,double side3)
        {
            if (side1 ==side2 && side2 ==side3)
            {
                return "Equilateral Triangle";
            }
            else if (side1 ==side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles Triangle";
            }
            else
            {
                return "Scalene Triangle";
            }
        }

    }
}
