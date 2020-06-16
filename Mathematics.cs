using System;

namespace logic 
{
    class Mathematics
    {
        //what will be returned = int in this case

        // int = -2,147,483,648 to 2,147,483,647 - 11
        // double = 1.7E +/- 308 (15 digits) - 11.5 
        // float = 3.4E +/- 38 (7 digits)  - 11.5f
        // decimal - 11.5m
        public double Addition(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }
        // waaaaait a minute.
        public float Division(float numberOne, float numberTwo)
        {
            return numberOne / numberTwo;
        } 
    }
}