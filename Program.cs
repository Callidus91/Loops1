using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int rows = 5;
            for (i = 2; i < rows; i++)
            {
                for (j = 1; j <= rows; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
