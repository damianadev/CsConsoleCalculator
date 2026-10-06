using System;

public static class Calculator
{

    public static void Main()
    {
        Console.WriteLine("Enter first digit");

        string? inputdigit1 = Console.ReadLine();

        if (decimal.TryParse(inputdigit1, out decimal digit1))
        {
            Console.WriteLine("First digit: " + digit1);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }



        Console.WriteLine("Enter second digit");

        string? inputdigit2 = Console.ReadLine();

        if (decimal.TryParse(inputdigit2, out decimal digit2))
        {
            Console.WriteLine("Second digit: " + digit2);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }



        Console.WriteLine("Enter operation: +   -   *   /");

        string? operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(digit1 + digit2);
        }
        else if (operation == "-")
        {
            Console.WriteLine(digit1 - digit2);
        }
        else if (operation == "*")
        {
            Console.WriteLine(digit1 * digit2);
        }
        else if (operation == "/")
        {
            if (digit2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                Console.WriteLine(digit1 / digit2);
            }
        }
        else
        {
            Console.WriteLine("Error: Operation failed");
        }

    }
}
