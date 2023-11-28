
/*
 *Bir class içerisinde aynı isimde birden fazla metot tanımlanamaz!  belirli kurallar dışında
 *İşte bu kurallar çerçevesinde bir class’ta aynı isimde birden fazla metot tanımlanırsa o metoda overloading yapılmış olacaktır.
 *Overloading:Çoklu yükleme 
 *Bir class'ta aynı isimde birden fazla metot tanımlanmışsa eğer (belirli kurallar çerçevesinde) o isme overloading
 *yapılmıştır.
 *Bir class içerisinde belirli kurallar çerçevesinde aynı isimde birden fazla metot oluşturmaya Method Overloading denir.
 *Esasında overloading (aşırı yükleme) yapılmış metotda parametre sayıları aynı ve çoklu yükleme,
 *parametrenin türleri ile gerçekleştirilmişse burada varsayılan türler dikkate alınmalıdır!
 *Ancak overloading’ler arasında varsayılan tür yani integer yok ise bu durumda da gönderilen değerin değer aralığına
 *göre metotlar tetiklenecektir.

 
 Overloading Kuralları:Bir sınıf içerinde birden fazla aynı isimde metot tanımlayabilmek için şu kurallara dikkat edilmesi gerekmektedir.
1)Metot Overloading işlemini yapabilmek için metotların isimleri aynı olmalıdır.
2)Bu metotlar içerisinde fark yaratmamız gerekmektedir.
3)Bu fark bizzat metot imzalarında olmalıdır.
4)Metotlar arasında farkı yaratırken erişim belirleyicileri ve geriye dönüş değerleri aktif rol oynamamaktadır.
5)Parametre sayıları ya da parametre türleri farklı olmalıdır.En önemli kuraldır.En çok dikkate alınması gerekn tek kural.

*Overloading işlemine tabi tutulmuş metotlardan istediğimizi kullanabilmek için o metodun imzasına uygun parametreleri tetiklememiz
*(ya da bir başka deyişle o imzadaki metodu kullanmamız) yeterli olacaktır.
Not:Programlamada temelde bir sayı varsayılan(default) olarak int türündedir. 
Not:overloading = bir class içinde aynı isimde birden fazla metot(fonksiyon) tanımlamaktır.
Metotların overloading'ini oluşturmak için her yeni oluşturulacak metodun parametrelerinin ya türleri ya da sayıları farklı olmalıdır.
 
 */


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