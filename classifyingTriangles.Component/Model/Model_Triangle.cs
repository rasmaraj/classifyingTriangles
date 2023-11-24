using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classifyingTriangles.Component.Model
{
   public class Model_Triangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public Model_Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
    }
}
