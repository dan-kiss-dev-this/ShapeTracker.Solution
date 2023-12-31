namespace ShapeTracker.Models
{
    public class Triangle
    {
        // code for triangle business logic will go in here

        private int _side1;
        private int _side2;
        private int _side3;


        //the constructor is below, note parameters are variables so they are lower cased
        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            _side2 = length2;
            _side3 = length3;
        }

        public int GetSide1()
        {
            return _side1;
        }

        public int GetSide2()
        {
            return _side2;
        }

        public int GetSide3()
        {
            return _side3;
        }

        public void SetSide1(int newSide)
        {
            _side1 = newSide;
        }

        public void SetSide2(int setSide)
        {
            _side2 = setSide;
        }

        public void SetSide3(int setSide)
        {
            _side3 = setSide;
        }

        // class method note include return type, public is access modifier, string is return type, TypeCheck is name of method
        public string CheckType()
        {
            if (_side1 > (_side2 + _side3) || (_side2 > (_side1 + _side3)) || (_side3 > (_side1 + _side2)))
            {
                return "Not a triangle";
            }
            else if ((_side1 != _side2) && (_side1 != _side3) && (_side2 != _side3))
            {
                return "scalene triangle";
            }
            else if ((_side1 == _side2) && (_side1 == _side3))
            {
                return "equilateral triangle";
            }
            else
            {
                return "isosceles triangle";
            }
        }
    }
}