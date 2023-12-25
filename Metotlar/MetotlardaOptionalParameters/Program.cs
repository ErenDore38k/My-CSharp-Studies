

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            X(15); 
            
            
            
        }

        static public void X(int a , int b = 0,int c = 0)
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}