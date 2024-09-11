using System;


namespace ssITP10CSharpPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion : Print even or odd numbers in a given range: ");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Input the range to print starting from 1: ");


            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"All even numbers from 1 to {n} are:\n");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i}\t");

            }
            Console.Write($"\nAll odd numbers from 1 to {n} are: \n");
            for (int i = 1; i <= n; i++) {
                
                if (i % 2 != 0)
                    Console.Write($"{i}\t");


            }

            Console.ReadLine();

        }
    }
}
