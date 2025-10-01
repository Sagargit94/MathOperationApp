using System;

namespace MathOperationApp
{
    // Define a class named MathHandler
    class MathHandler
    {
        // Define a method that takes two integers as parameters
        // Performs a math operation (e.g., multiplies first number by 2)
        // and displays the second number
        public void DoMathOperation(int number1, int number2)
        {
            // Multiply number1 by 2
            int result = number1 * 2;

            // Print the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second number
            Console.WriteLine("Second number is: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathHandler class
            MathHandler mathHandler = new MathHandler();

            // Call the method with two numbers (positional parameters)
            mathHandler.DoMathOperation(5, 10);

            // Call the method with named parameters
            mathHandler.DoMathOperation(number1: 7, number2: 20);

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
