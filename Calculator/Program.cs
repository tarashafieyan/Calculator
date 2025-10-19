using System;
namespace Program
{
    public class main()
    {
        public static void Main()
        {
            Console.WriteLine("your welcome to Calculator Project");
            while (true)
            {
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Sine");
                Console.WriteLine("6: Cosine");
                Console.WriteLine("7: Logarithm (natural log)");
                Console.WriteLine("0: Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                    break;
                Console.WriteLine("enter the first number:");
                double number1;
                if (!double.TryParse(choice, out number1))
                {
                    Console.WriteLine("\nInvalid number!");
                    continue;
                }
                double number2 = 0;
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    Console.WriteLine("enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out number2))
                    {
                        Console.WriteLine("Invalid number!");
                        continue;
                    }
                }
                double result = 0;
                switch (choice)
                {
                    case "1":
                        result = number1 + number2;
                        break;
                    case "2":
                        result = number1 - number2;
                        break;
                    case "3":
                        result = number1 * number2;
                        break;
                    case "4":
                        result = number1 / number2;
                        break;
                    case "5":
                        result = Math.Sin(number1);
                        break;
                    case "6":
                        result = Math.Cos(number2);
                        break;
                    case "7":
                        result = Math.Log(number1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;

                }
                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }

        }
    }
}