using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select an operation (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }

        Console.WriteLine("Result: " + result);
        Console.ReadKey();
    }
}
