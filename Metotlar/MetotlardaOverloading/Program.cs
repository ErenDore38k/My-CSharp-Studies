

using System;
using System.Reflection.Metadata.Ecma335;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            matematik.Topla(2, 5);
            matematik.Topla(2, 5, 1, 2);
        }

        class Matematik
        {
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Topla(int sayi1, double sayi2)
            {
                return (int)(sayi1 + sayi2);
            }

            public int Topla(int sayi1,int sayi2,int sayi3)
            {
                return sayi1+sayi2 + sayi3;
            }
            public int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
            {
                return sayi1 + sayi2 + sayi3 + sayi4;
            }

            public int Topla(byte sayi1, int sayi2, int sayi3, int sayi4)
            {
                return sayi1 + sayi2 + sayi3 + sayi4;
            }

        }
    }
}