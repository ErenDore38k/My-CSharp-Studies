
/*
 *Başka Sınıfta Tanımlanmış Metotların Erişimi-Referans ve Nesne İlişkisine Hafiften Temas Edelim
 *Bir class içerisinde oluşturduğumuz metotların diğer class'lar içerisinde erişilebilmesini işleyebilmemiz,anlayabilmemiz
 *için class,nesne ve referans ilişkilerini hasbelkader bilmemiz gerekmektedir.
 
 *Class(sınıf):Oluşturduğumuz değerlerin (field vb),metotların;-prensip olarak ortak bir sorumlukukta-kategorize edilmesini,
 *modellenmesini sağlayan bir yapıdır,şeklinde öncül bir işlevini tanım olarak kabul ederiz.
 *Class'lar(sınıflar) tek bir sorumluluğa  odakte olmalı.(tek sorumluluk prensibi)
 *Class yeryüzndeki herhangi bir olguyu modellememizi sağlayan yapılanma.İçerisinde ilgili olguya dair verileri tutacak
 *alanları(field)barındıran ve bu alanlar üzerinde işlem yapmamızı sağlayacak olan metotları barındıran bir yapı.
 

 
 *Object(nesne):Nesne ise bu class'ın verisidir.Yani class dediğimiz modelden oluşturulmuş/üretilmiş veridir.
 *Nesne  class'tan üretilen değer/veri.
 *REFERANS'DA bu classtan üretilen veriyi kullanmamızı sağlar. 
 *Referans class'tan üretilen kullanmamızı sağlayan yapı.
 * Class(Sınıf)=> Object(Nesne)=>Method(Metot)
 * Örn:Bir ev düşünelim bu evin tamamı sınıf diye ele alalım. Evdeki eşyalar,insanlarda bu durumda nesne olmuş olur.
 * 
 *Farklı sınıflarda oluşturulmuş metotlara erişebilmek için o sınıflardan nesne oluşturmamız gerekmektedir.
 *Nesneyi de "new" keyword'ü ile oluşturmaktayız.
 *Type Class türüdür.
 *	Type [ Referans İsmi ] = new Type();
‼ Buradaki = (assign) olarak adlandırdığımız eşittir operatörü ise bizler için artık referans etme operatörü olacaktır.

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