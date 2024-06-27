public class InputHandler
{
    public int GetOperationChoice()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 5)
        {
            return choice;
        }
        Console.Clear();
        Console.WriteLine("Invalid choice. Please select a valid operation.");
        return GetOperationChoice();
    }

    public double GetNumber(string prompt)
    {
        Console.WriteLine(prompt);
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            return number;
        }
        Console.Clear();
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return GetNumber(prompt);
    }
}
