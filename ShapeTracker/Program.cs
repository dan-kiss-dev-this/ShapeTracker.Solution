using System;
using ShapeTracker.Models; // called a directive

namespace ShapeTracker
{
    class Program
    {
        static void Main()
        {
            // we will add user interface code here
            Triangle testTriangle = new Triangle(4, 4, 4);
            // Console.WriteLine(testTriangle.GetType());
            Console.WriteLine($"Side 1 of the triangle {testTriangle.GetSide1()}");
            Console.WriteLine($"Side 2 of the triange {testTriangle.GetSide2()}");
            Console.WriteLine($"Side 3 of the triange {testTriangle.GetSide3()}");
            Console.WriteLine($"Calculating...");
            Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}");
        }
    }

}