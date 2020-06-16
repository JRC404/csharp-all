using System;

namespace introduction
{
    class Encapsulation
    {
      /*

      private - limiting access to the same class
      public - free for all... any object can access that data
      protected - limiting access to the same class OR descendants
      internal - c# only for OOP... limiting access to a namespace (assembly)

      good? 
      1. human error
      2. allowing access to a 'floor' but not saying how we got there...
          keeping the logic intact, keeping the logic a secret... just letting them access data
      3. Keeping it clean... efficient... easier to understand... HAVE to... not just should...
      PLAN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      Bad?
      1. human error
      2. Very easy to misunderstand OR get wrong...
      3. Can be very long-winded...

      Example:

      Order details:

          * User submits their delivery and billing address
          * An issue may arise with accessing the details

      */
        private string name;
        private double salary;

        public void Information()
        {
          name = "Frankie";
          Console.WriteLine($"My name is {name}");
          /*

          create multiple variables about yourself declared as private
          then create a public method to access the variables in a structured way
          Console.WriteLine about yourself
          Display that method inside of Program.cs

          */
        }
    }
}