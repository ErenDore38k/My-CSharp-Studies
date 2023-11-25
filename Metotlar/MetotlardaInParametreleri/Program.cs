

/*
 *Metotlarda In Parametreleri (C# - In Keywordü)
 *Parametrelere Dair Not:
 1)Parametre'nin değerini metodun içerisinde herhangi bir yerde çağırıp kullanabiliriz.
 2)Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz.
Yani parametrenin değerini degiştirebiliriz.Çünkü parametreler özünde bir değişkendir.


 *(C# - In Keywordü)
 *In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
 *In komutu,metodun parametresini readonly(sadece okunabilir) hale getirir.
 *In komutunun kullanıldığı parametrelerde eğer ki metot içerisinde farklı bir assing durumu söz konusu olursa derleyici
 *hatası verecektir.
 * 
 * 
 * 
 * 
 * 
 */

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

            X(a, b, c); //X fonksiyonunu çağırma
        }

        static void X(in int a,int b ,in char c) 
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}