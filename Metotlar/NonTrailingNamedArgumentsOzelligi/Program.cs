

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            X(c: "abc", a: 5, b: 15);
        }

        static void X(int a, int b, string c)
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}