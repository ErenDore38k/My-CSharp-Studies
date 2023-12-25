

using System;

namespace functions
{

    class Program
    {
        static void Main(string[] args)
        {
            X();
        }

        public static void X() 
        {
            Y();
            void Y()
            {
                System.Console.WriteLine("Yazılım güzeldir");
            }
            Y();
        }
    }
}