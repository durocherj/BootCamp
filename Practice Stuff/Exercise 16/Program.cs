using System;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                string triangle = new string('*', i);
                Console.WriteLine(triangle);
            }

        }
    }
}
