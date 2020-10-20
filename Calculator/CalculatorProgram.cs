using CalculatorLibrary;
using System;

namespace CalculatorProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;

            while (!closeApp)
            {
                // Declare variables and set to empty.
                var input1 = "";
                var input2 = "";
                double result = 0;

                // first number
                Console.Write("Type a number, and then press Enter: ");
                input1 = Console.ReadLine();

                double int1 = 0;
                while (!double.TryParse(input1, out int1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    input1 = Console.ReadLine();
                }

                // second number.
                Console.Write("Type another number, and then press Enter: ");
                input2 = Console.ReadLine();

                double int2 = 0;
                while (!double.TryParse(input2, out int2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    input2 = Console.ReadLine();
                }

                // choose operation
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(int1, int2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") closeApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}