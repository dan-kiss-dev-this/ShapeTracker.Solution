namespace ShapeTracker.Models
{
    public class Triangle
    {
        // code for triangle business logic will go in here
        public int Side1;
        public int Side2;
        public int Side3;

        //the constructor is below, note parameters are variables so they are lower cased
        public Triangle(int length1, int length2, int length3)
        {
            Side1 = length1;
            Side2 = length2;
            Side3 = length3;
        }

        // class method note include return type, public is access modifier, string is return type, TypeCheck is name of method
        public string CheckType()
        {
            if (Side1 > (Side2 + Side3) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
            {
                return "Not a triangle";
            }
            else if ((Side1 != Side2) && (Side1 != Side3) && (Side2 != Side3))
            {
                return "scalene triangle";
            }
            else if ((Side1 == Side2) && (Side1 == Side3))
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