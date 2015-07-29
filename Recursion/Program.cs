using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(n);

            Console.WriteLine("N! = {0}", result);
            Console.WriteLine("---------------------------");
            Console.WriteLine("All binary vectors:");
            GenerateBinaryVectors(new int[n], 0);
        }

        static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N must be a positive number");
            }

            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        static void GenerateBinaryVectors(int[] vector, int currentIndex)
        {
            if (currentIndex == vector.Length)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i]);
                }

                Console.WriteLine();
                return;
            }

            vector[currentIndex] = 0;
            GenerateBinaryVectors(vector, currentIndex + 1);

            vector[currentIndex] = 1;
            GenerateBinaryVectors(vector, currentIndex + 1);
        }
    }
}
