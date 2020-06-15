using System; 
// a library that will be essential for the majority of our first week... 
// without it... we will have lengthy paths.

namespace introduction
// any class inside of the namespace will be available... 
// we will see this more in later projects
{
    class Mathematics
    {
        // encapsulation
        public int Addition(int numberOne, int numberTwo) // capitalised is best.. but not essential here...
        {
            return numberOne + numberTwo;
        }
        public int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        public int Multiplication(int numberOne, int numberTwo)
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
        public void Nothing()
        {
            Console.WriteLine("Hello, Nothing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            dean.Dean myDeanNotYoursMine = new dean.Dean();
            int addMe = maths.Addition(1, 3);
            Console.WriteLine(addMe);
            float divideMe = maths.Division(10,3);
            Console.WriteLine(divideMe);
        }
    }
}

/*

    int = Stores whole numbers from -2,147,483,648 to 2,147,483,647
    long = Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

    string = can handle a string of text
    char = character
    char myFirstLetter = "N";    

*/
