

using System;

namespace functions
{

    class Program
    {
        static void Main(string[] args)
        {
            Topla(3,5);
        }

       static public int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        } 
    }
}