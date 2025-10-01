using System;

// Define a namespace to organize classes
namespace MathOperationApp
{
    // Define a class named MathOperation
    public class MathOperation
    {
        // Create a method that takes two integers as parameters
        // The method performs a math operation on the first integer and displays the second integer
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2 (you can choose any math operation)
            int result = firstNumber * 2;

            // Display the result of the operation on the first number
            Console.WriteLine("Result of operation on first number: " + result);

            // Display the second number directly
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    // The main Program class where execution starts
    class Program
    {
        // The Main method is the entry point of the application
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Call the method using positional arguments
            mathOp.PerformOperation(5, 10);

            // Call the method using named parameters
            mathOp.PerformOperation(firstNumber: 7, secondNumber: 14);

            // Wait for user input before closing the console (so output can be read)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
