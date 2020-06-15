using System;

namespace introduction
{
    class AgeCalculator
    {
        public void Calculator(int age)
        {
            /*
                Check to see whether someone is allowed in to the club
                < 18 - nooooo
                < 40 - allowed in
                < 65 - allowed in unaccompanied but out by 11
                < 100 - senior discount with someone looking after you but out by 10:55
            */
            if (age < 18)
            {
                Console.WriteLine("Not allowed in");
            }
            else if (age < 40)
            {
                Console.WriteLine("Allowed in");
            }
            else if (age < 65)
            {
                Console.WriteLine("Out by 11");
            }
            else
            {
                Console.WriteLine("Senior discount");
            }
        }
    }
}