using System;

namespace Logic 
{
    class Mathematics
    {
        // encapsulation
        public double Addition(double numberOne, double numberTwo) // capitalised is best.. but not essential here...
        {
            return numberOne + numberTwo;
        }
        public double Subtraction(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
        public decimal Multiplication(decimal numberOne, decimal numberTwo)
        {
            return numberOne * numberTwo;
        }
        // waaaaait a minute.
        public float Division(float numberOne, float numberTwo)
        {
            // decimal = floating point number
            // 0.000
            return numberOne / numberTwo;
        }
    }
}