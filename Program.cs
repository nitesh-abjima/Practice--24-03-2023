// See https://aka.ms/new-console-template for more information
using System;
namespace MethodDemo
{
    class Example
    {
        static void EvenOrOdd(int n)
        {
            if (n % 2 == 0) 
                Console.WriteLine("{0} is even", n);
            else
                Console.WriteLine("{0} is odd", n);
        }

        //Program to find factorial of a number using recursion
        static int Factorial(int n)
        {
            if ((n == 0) || (n == 1))
                return 1;
            else
                return n * Factorial(n - 1);
        }

        //Program that demonstrates passing by value in C#
        static void Swap(int m, int n)
        {
            int temp;
            temp = m;
            m = n;
            n = temp;
        }
        static void Main(string[] args)
        {
            EvenOrOdd(5);
            EvenOrOdd(8);

            //Program to find factorial of a number using recursion

            Console.WriteLine("Factorial of 5 is {0}", Factorial(5));
            Console.WriteLine("Factorial of 8 is {0}", Factorial(8));

            //Program that demonstrates passing by value in C#

            int a = 5;
            int b = 10;
            Console.WriteLine("Passing By Value");
            Console.WriteLine("Before Swap method is called");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Swap(a, b);
            Console.WriteLine("After Swap method is called");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
