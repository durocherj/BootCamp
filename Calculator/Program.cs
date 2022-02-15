using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculord!!!");
            bool again = true;
            while (again)
            {
                Console.WriteLine("What sort of operation will we be doing today?\nYour options are: addition, subtraction, multiplication, or division:");
                var answer = Console.ReadLine().ToLower();
                


                switch (answer)
                {
                    case "addition":
                        Console.Write("Please enter the first number to be added:");
                        var input1 = Console.ReadLine();
                        int a;
                        bool number1 = int.TryParse(input1, out a);

                        Console.Write("Please enter the second number to be added:");
                        var input2 = Console.ReadLine();
                        int b;
                        bool number2 = int.TryParse(input2, out b);

                        var sum = Add(a, b);
                        Console.WriteLine(sum);
                        break;

                    case "subtraction":
                        Console.Write("Please enter the number you will start with:");
                        var input3 = Console.ReadLine();
                        int c;
                        bool number3 = int.TryParse(input3, out c);

                        Console.Write($"Please enter the number we are removing from {c}: ");
                        var input4 = Console.ReadLine();
                        int d;
                        bool number4 = int.TryParse(input4, out d);

                        var diff = Subtract(c, d);
                        Console.WriteLine(diff);
                        break;

                    case "multiplication":
                        Console.Write("Please enter the first number to be multiplied: ");
                        var input5 = Console.ReadLine();
                        int e;
                        bool number5 = int.TryParse(input5, out e);

                        Console.Write("Please enter the second number to be multiplied: ");
                        var input6 = Console.ReadLine();
                        int f;
                        bool number6 = int.TryParse(input6, out f);

                        var product = Multiply(e, f);
                        Console.WriteLine(product);

                        break;

                    case "division":
                        Console.WriteLine("Please enter the number we will be dividing from: ");
                        var input7 = Console.ReadLine();
                        int g;
                        bool number7 = int.TryParse(input7, out g);

                        Console.Write($"Please enter the number we will be dividing into {g}: ");
                        var input8 = Console.ReadLine();
                        int h;
                        bool number8 = int.TryParse(input8, out h);
                        if (h == 0)
                        {
                            Console.WriteLine("THOU SHALT NOT DIVIDE BY 0!!!!");
                        }
                        else
                        {
                            var result = Divide(g, h);
                            Console.WriteLine(result);
                        }

                        break;

                    default:
                        Console.WriteLine("Please stick to the list provided.");
                        break;







                }

                Console.Write("Would you like to try again? (y/n)");
                var repeat = Console.ReadLine().ToLower();

                if(repeat == "y")
                {
                    continue;
                }
                else
                {
                    again = false;
                }
            }


        }
        
        
        public static string Add(int a, int b)
        {
            var sum = a + b;
            return $"The sum of {a} and {b} is {sum}.";
        }
        public static string Subtract(int a, int b)
        {
            var diff = a - b;
            return $"{a} minus {b} is {diff}.";
        }
        public static string Multiply(int a, int b)
        {
            var product = a * b;
            return $"{a} times {b} is {product}.";
        }
        public static string Divide(int a, int b)
        {
            double result = (double)a / (double)b;
            return $"{a} divided by {b} is {result}";
        }
    }
    
}
