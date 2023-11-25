
/*
 *Metotlarda Non Trailing Named Arguments Özelliği
 *Hangi parametreye hangi değerlerin gönderildiğini direkt görebilmek için bu özelliği kullanırız.
 *Göreceli bir şekilde çok parametreli fonksiyonlarda hedef parametrelere değer göndermemizi sağlayan bir özelliktir.
 *Bildiğimiz gibi parametre alan metotlarda,parametrelerin her birine sırasına ve türüne uygun değer göndermeliyiz ancak
 *bu sıranın dışında kendi istediğimiz düzende değer göndermek istersek Non Trailing Named Arguments özelliğini 
 *kullanabiliriz.
 */

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //X(3, 5, "abc");
            X(c: "abc", a: 5, b: 15);
        }

        static void X(int a, int b, string c)
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}