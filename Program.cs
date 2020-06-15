using System; 
// a library that will be essential for the majority of our first week... 
// without it... we will have lengthy paths.

namespace introduction
// any class inside of the namespace will be available... 
// we will see this more in later projects
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Logic.Mathematics maths = new Logic.Mathematics();
            AgeCalculator checkAge = new AgeCalculator();
            Console.Write("Please enter your age: ");
            // when to use Write or WriteLine?
            string userInput = Console.ReadLine();
            // why can't I use string with ReadKey but I can with ReadLine?
            string naomi = "hello";
            Console.WriteLine("The user said they were {0}. {1}", userInput, naomi);
            // older applications will use above "{0}, userInput"
            Console.WriteLine($"The user said they were {userInput}. {naomi}");
            // new applications will use above $"{userInput}"
            Console.WriteLine("The user said they were " + userInput + " " + naomi + ".");
            // ummmm.

            // checkAge.Calculator(Convert.ToInt32(userInput));
            // checkAge.Calculator(Int32.Parse(userInput));
            
            // double addMe = maths.Addition(14.50, 76.30);
            // double subtractMe = maths.Subtraction(149.50, 76.30);
            // decimal multiplyMe = maths.Multiplication(35.45m, 67.98m);
            // float divideMe = maths.Division(10f, 3f); // 123.3f
            // // float = 123.3f
            // // double = 123.3
            // // decimal = 123.3m

            // // int subtractMe = maths.Subtraction(34.7, 11.1);
            // Console.WriteLine(addMe);
            // Console.WriteLine(subtractMe);
            // Console.WriteLine(multiplyMe);
            // Console.WriteLine(divideMe);
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
