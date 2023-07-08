using System.Collections.Generic;
namespace ShapeTracker.Models
{
    public class Triangle
    {
        // code for triangle business logic will go in here

        private int _side1;
        // below makes a private _side2 field with getter and setter
        public int Side2 { get; set;}
        private int _side3;
        private static List<Triangle> _instances = new List<Triangle> { };


        //the constructor is below, note parameters are variables so they are lower cased
        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            Side2 = length2;
            _side3 = length3;
            _instances.Add(this);
        }

        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        // will access get as tri.GetSide() to tri.Side1
        // access set as tri.SetSide1(stringNumber1) to tri.Side1 = stringNumber1

        // longer version with no syntactic sugar
        // public int GetSide1()
        // {
        //     return _side1;
        // }
        // public void SetSide1(int newSide)
        // {
        //     _side1 = newSide;
        // }

     

        public int Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }

        // class method note include return type, public is access modifier, string is return type, TypeCheck is name of method
        public string CheckType()
        {
            if (_side1 > (Side2 + _side3) || (Side2 > (_side1 + _side3)) || (_side3 > (_side1 + Side2)))
            {
                return "Not a triangle";
            }
            else if ((_side1 != Side2) && (_side1 != _side3) && (Side2 != _side3))
            {
                return "scalene triangle";
            }
            else if ((_side1 == Side2) && (_side1 == _side3))
            {
                return "equilateral triangle";
            }
            else
            {
                return "isosceles triangle";
            }
        }

        public static List<Triangle> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}