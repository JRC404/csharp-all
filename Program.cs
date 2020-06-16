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
            logic.Mathematics maths = new logic.Mathematics();
            logic.Controller controller = new logic.Controller(); 
            Encapsulation example = new Encapsulation();
            example.Information();
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
