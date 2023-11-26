

/*
 *Static Local Functions(Metot İçerisinde Tanımlanabilir Statik Yerel Metotlar) 
 *Static Local Functions kullanmak Local Functions kullanmaya nazaran daha performanslıdır.
 */

using System;

namespace functions
{

    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.X(45);
        }

       public void X(int a)
        {
            int b = 0;
           static void Y(int a,int b)
            {
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
            }
            Y(a,b);
        }
    }
}




