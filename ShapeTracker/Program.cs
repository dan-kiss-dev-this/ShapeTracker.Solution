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
            Console.WriteLine("Updating...");
            testTriangle.SetSide1(44);
            testTriangle.SetSide2(44);
            testTriangle.SetSide3(70);
            Console.WriteLine($"Actually I changed the values of your triangles sides to {testTriangle.GetSide1()} and {testTriangle.GetSide2()} and {testTriangle.GetSide3()}");
            Console.WriteLine($"Now your triangle is: {testTriangle.CheckType()}.");
        }
    }

}