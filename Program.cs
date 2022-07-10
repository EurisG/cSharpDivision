// This tells c# to import everything from system into the console
using System; 

// This namespace is the parent of all the classes and objects inside of it . 
// we can nest another namespace 
namespace MyProgram {

// 
    class program {

        static void Main(string[] args) {

            // declaring variables using int and double
            // double will result in really big numbers AND numbers that have a decimal
            int x;
            int y;
            double result;

           try {
               Console.WriteLine("LETS DIVIDE!");

               Console.Write("Enter a number: ");
            //    Converts the integer into a string
               x = Convert.ToInt32(Console.ReadLine());

               Console.Write("Enter another number: ");
               //    Converts the integer into a string
               y = Convert.ToInt32(Console.ReadLine());

               result = x / y;

               Console.WriteLine("Answer is " + result);
           }  
        //    This format exception will handle any exception that isnt an integer
           catch (FormatException e)
           {
                Console.WriteLine("Please enter a number");
           } 
        //    This will handle if person tries to divide by 0
           catch (DivideByZeroException e) 
           {
               Console.WriteLine(e.Message);
           }
        //    This will handle every Exception
          catch (Exception e) 
          {
              Console.WriteLine(e.Message);
          }
        //   This finally block lets the user know is the end of the file and will need to reOpen it in order to try another division
          finally 
          {
              Console.WriteLine("Thank you for coming!");
          }
        }
    }
}


