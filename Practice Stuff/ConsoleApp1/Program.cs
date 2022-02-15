using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculord!!!");

        }
    }

    public class Calculator
    {
        public int CalcSum(int a, int b)
        {
            var sum = a + b;
            return sum;
        }
        public int Multiply(int a, int b)
        {
            var sum = a * b;
            return sum;
        }
    }
}
