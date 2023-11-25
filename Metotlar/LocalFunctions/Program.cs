
/*
 *Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar)
 *Local Functions:Bir metot içerisinde tanımlanmış olan metotlardır.
 *C#'ta metotlar sade ve sadece class içerisinde tanımlanırlar diye söylemiştik.Halbuki OOP'de  göreceğimiz struct,abstract
 *class,interface,record yapılanmalarında da metotlar tanımlanmaktadır.
 *Metotlar bu saydıklarımızın dışında kesinlikle başka bir yerde tanımlanamaz!!!!!!
 *Metotlar kesinlikle metotların içerisinde tanımlanamaz demiştik!! Halbuki C#7.0'da gelen Local Function özelliği sayesinde
 *metot içerisinde metot tanımlanabilmektedir.
 
 *Not:Erişim Belirleyicisi ne bir hatırlayalım.Tanımlanmış metodun tanımlandığı sınıf dışından erişilip erişilememesi
 *durumunu belirleyen ifadelerdir.
 
 *Local Functions erişim belirleyicileri yoktur.Yani direkt geri dönüş değerinden başlanır.
 
 Tanımlama Kuralları: 
 1)Erişim belirleyici(Access Modifier) yazılmaz.
 2)Local function olarak tanımlanan fonksiyon adı tanımlandığı fonksiyonun adından farklı olmalıdır.Aksi takdirde 
derleyici hatası vermez!!!

Kullanım Kuralları:
1)Bir local function sade ve sadece tanımlandığı metodun içerisinde kullanılabilir.
2)Local fonction tanımlandığı metodun içerisinde her yerden erişilebilir.


Amacı: 

 */

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