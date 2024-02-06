using Mathematics;
using System;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            /*foreach (var a in args)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();*/
            AreArgumentsValid(args);

            var math = new BasicMath();
            var advmath = new AdvMath();
            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break;

                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {math.SubtractNumbers(_num1, _num2)}");
                    break;

                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {math.MultiplyNumbers(_num1, _num2)}");
                    break;

                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {math.DivideNumbers(_num1, _num2)}");
                    break;

                case "are":
                    Console.WriteLine($"{_num1} * {_num2} = {advmath.CalculateArea(_num1, _num2)}");
                    break;

                case "avg":
                    Console.WriteLine($"Average: {advmath.CalculateAverage(new List<double> { _num1, _num2 })}");
                    break;

                case "sqr":
                    Console.WriteLine($"{_num1} ^ 2 = {advmath.CalculateSquared(_num1)}");
                    break;

                case "pyt":
                    Console.WriteLine($"Hypotenuse: {advmath.CalculatePT(_num1, _num2)}");
                    break;


                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul, Div, Sqr");
                    break;
            }
            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            _num1 = NumParser(args[2]);
            if (args.Length >= 4)
            {
                _num2 = NumParser(args[3]);
            }
            else
            {
                _num2 = 0;
            }
            Console.WriteLine("All Arguments are valid!");
        }

            public static double NumParser(string arg)
        {
            double number;
            if (Double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }

            return 0;
        }
    }
}