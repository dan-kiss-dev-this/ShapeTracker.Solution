namespace ShapeTracker.Models
{
    public class Triangle
    {
        // code for triange business logic will go in here
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
            return "Sorry I don't have an answer yet";
        }
    }
}