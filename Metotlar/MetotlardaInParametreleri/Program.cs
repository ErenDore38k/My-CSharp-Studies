

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            char c = 'q';

            X(a, b, c); 
        }

        static void X(in int a,int b ,in char c) 
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}