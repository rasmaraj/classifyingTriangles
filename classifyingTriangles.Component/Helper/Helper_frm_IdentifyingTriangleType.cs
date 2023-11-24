using classifyingTriangles.Component.Interaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classifyingTriangles.Component.Helper
{
   public class Helper_frm_IdentifyingTriangleType
    {
        public static string checkTriangleTye(string side1,string side2,string side3)
        {
            var result = validateSides(side1.Trim(), side2.Trim(), side3.Trim());
            //Check validation count
            if (result.Item1.Count != 0)
            {
                return string.Join(Environment.NewLine, result.Item1);
            }
            else
            {
                ITriangleType triangleType = new BLL.TriangleTypeDetector();
                //Identifying triangleType 
                return triangleType.GetTriangleType(result.Item2.side1, result.Item2.side2, result.Item2.side3);
            }
        }
        #region Validate sides of triangle 
        private static Tuple<HashSet<string>,Model.Model_Triangle> validateSides(string side1, string side2, string side3)
        {
            var result = new HashSet<string>();
            double _side1 = 0, _side2 = 0, _side3 = 0;
            if (string.IsNullOrWhiteSpace(side1) || !double.TryParse(side1, out  _side1) || _side1<=0)
            {
                result.Add("Invalid Side 1");
            }
            if (string.IsNullOrWhiteSpace(side2) || !double.TryParse(side2, out  _side2) || _side2<= 0)
            {
                result.Add("Invalid Side 2");
            }
            if (string.IsNullOrWhiteSpace(side3) || !double.TryParse(side3, out  _side3) || _side3<= 0)
            {
                result.Add("Invalid Side 3");
            }

            if (result.Count==0 && !IsValidTriangle(_side1,_side2,_side3))
            {
                result.Add("Invalid triangle: Sum of any two sides must be greater than the third side");
            }
            var model = new Model.Model_Triangle(_side1, _side2, _side3);
            return new Tuple<HashSet<string>, Model.Model_Triangle>(result, model); ;
        }
        //validate triangle
        private static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
        #endregion




    }
}
