using System;
using ShapeTracker.Models; // called a directive
using System.Collections.Generic;

namespace ShapeTracker
{
    class Program
    {
        static void Main()
        {
            List<Triangle> allTriangles = Triangle.GetAll();
            // we will add user interface code here
            Triangle testTriangle = new Triangle(4, 4, 4);
            Triangle secondTriangle = new Triangle(32, 74, 75);

            if (allTriangles.Count == 0)
            {
                Console.WriteLine("There are no triangles");
            }
            else
            {
                Console.WriteLine("------------------");
                foreach (Triangle tri in allTriangles)
                {
                    Console.WriteLine($"Side 1 of the triangle: {tri.GetSide1()}");
                    Console.WriteLine($"Side 2 of the triangle: {tri.GetSide2()}");
                    Console.WriteLine($"Side 3 of the triangle: {tri.GetSide3()}");
                    Console.WriteLine("------------------");
                }
            }
        }
    }

}