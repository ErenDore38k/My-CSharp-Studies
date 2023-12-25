

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Carp(3, 5));
        }

        class Matematik
        {
            public int Topla(int sayi1,int sayi2) 
            {
             return sayi1 + sayi2;   
            }
            public int Cikar(int sayi1,int sayi2)
            {
                return sayi1-sayi2;
            }
            public int Carp(int sayi1,int sayi2)
            {
                return sayi1 * sayi2;
            }
            public int Bol(int sayi1,int sayi2)
            {
                return sayi1 / sayi2;
            }
        }

    }
}