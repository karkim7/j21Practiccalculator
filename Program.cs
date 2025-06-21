using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Simple Calculator ---");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                running = false;
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                        Console.WriteLine("Error: Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
