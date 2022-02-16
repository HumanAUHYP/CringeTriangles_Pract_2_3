using System;

namespace CringeTriangles_Pract_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CringeTriangles triangle = null;
            while (triangle == null)
            {
                try
                {
                    triangle = new CringeTriangles(Console.ReadLine());
                    if (!triangle.IsValid())
                    {
                        triangle = null;
                        throw new Exception("Invalid user (Cringe triangle not created)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(triangle.GetSideType());
            Console.WriteLine(triangle.GetAngleType());
            Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
            
        }
    }
}
