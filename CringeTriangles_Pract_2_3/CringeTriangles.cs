using System;
using System.Collections.Generic;
using System.Text;

namespace CringeTriangles_Pract_2_3
{
    class CringeTriangles
    {
        double a;
        double b;
        double c;

        public CringeTriangles(double[] sides)
        {
            SetSides(sides);
        }

        public CringeTriangles(string sidesStr)
        {
            var temp = sidesStr.Split();
            double[] sides = new double[3];
            for (int i = 0; i < 3; i++)
            {
                sides[i] = double.Parse(temp[i]);
            }
            SetSides(sides);
        }

        private void SetSides(double[] sides)
        {
            a = sides[0];
            b = sides[1];
            c = sides[2];
        }

        public bool IsValid()
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        public string GetSideType()
        {
            if (a == b && a == c)
                return "Равносторонний";
            else if ((a == b && a != c) || (a == c && a != b))
                return "Равнобедренный";
            else
                return "Разносторонний";
        }

        public string GetAngleType()
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);
            var nedocos = sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2];
            if (nedocos > 0)
                return "Острый";
            else if (nedocos < 0)
                return "Тупой";
            else
                return "Прямой";
        }

        public double GetArea()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
