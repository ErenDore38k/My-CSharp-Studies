
/*
 *Tanımlanmış Metodun Kullanımı - Tanımlandığı Sınıf İçerisindeki Metotlar Tarafından Kullanımı
 *Tetikleme = Çağırma = Kullanımı 
 *Bir metot tanımlandığı sınıf içerisindeki farklı bir metot içerisinden çağrılacaksa eğer tek yapılması gereken
 *sadece isminin çağrılmasıdır.
 *Bir class içerisinde oluşturduğumuz metotların diğer class’lar içerisinde erişilebilmesini işleyebilmemiz,
 *anlayabilmemiz için class, nesne ve referans ilişkilerini hasbelkader bilmemiz gerekmektedir.

 */

using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            X(16);

        }

        static void X(int e )
        {
            Console.WriteLine(e);
        }

    }
}

/*class Örnek
{
    public void A()
    {

    }
    private void B()
    {
        C(5);
    }

    private int C(int a )
    {
        return a;
    }

}
*/