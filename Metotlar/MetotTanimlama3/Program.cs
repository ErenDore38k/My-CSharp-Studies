/*
 *Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Alan Metot Türü
 *
 * 
 * 
 * 
 * 
 * 
 */

using System;

namespace metotlar
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
        }

        public int Metot7(int x)
        {
            return DateTime.Now.Year >2000 ? 1 :0 ;
        }
    }
}
