using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;

class Calculate
{
    public static double Plus(double first, double second) => first + second;
    public static double Minus(double first, double second) => first - second;
    public static double Multi(double first, double second) => first * second;
    public static double Division (double first, double second) => first / second;
}

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter action(+ - / *): ");
            char action = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            while (action == '/' && second == 0)
            {
                Console.WriteLine("You can't divide by 0! Pleasl enter new second number");
                second = Convert.ToDouble(Console.ReadLine());
            }
            double result;
            const char plus = '+';
            const char minus = '-';
            const char multi = '*';
            const char division = '/';
            switch (action)

            {
                case plus:
                    {
                        result = Calculate.Plus(first, second);
                        Console.WriteLine($"Result {first} {action} {second} = {result}");
                        break;
                    }
                case minus:
                    {
                        result = Calculate.Minus(first, second);
                        Console.WriteLine($"Result {first} {action} {second} = {result}");
                        break;
                    }
                case multi:
                    {
                        result = Calculate.Multi(first, second);
                        Console.WriteLine($"Result {first} {action} {second} = {result}");
                        break;
                    }
                case division:
                    {
                        result = Calculate.Division(first, second);
                        Console.WriteLine($"Result {first} {action} {second} = {result}");
                        break;
                    }

            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

    }
    
}