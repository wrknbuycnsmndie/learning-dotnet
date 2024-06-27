using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;
            Calculator calculator = new Calculator();
            InputHandler inputHandler = new InputHandler();

            while (continueCalculation)
            {
                int choice = inputHandler.GetOperationChoice();

                if (choice == 5)
                {
                    continueCalculation = false;
                    continue;
                }

                double num1 = inputHandler.GetNumber("Enter the first number:");
                double num2 = inputHandler.GetNumber("Enter the second number:");

                try
                {
                    double result = choice switch
                    {
                        1 => calculator.Add(num1, num2),
                        2 => calculator.Subtract(num1, num2),
                        3 => calculator.Multiply(num1, num2),
                        4 => calculator.Divide(num1, num2),
                        _ => throw new InvalidOperationException("Invalid operation choice")
                    };

                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}
