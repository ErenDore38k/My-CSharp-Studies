
/*
 *Metodun parametre kısmında tanımlanıyorsa parametre,
 *metodun gövdesinde ya da class içerisinde tanımlanıyorsa değişken ya da field. 
 *Metotlarda sınırsız sayıda parametre değeri girilebilir. 
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
            Metot2(19);
            
        }

        public static void Metot2(int a ) 
        {
         Console.WriteLine("1923");
        }

        public void Metot3(int c,bool b)
        {

        }

    }
}