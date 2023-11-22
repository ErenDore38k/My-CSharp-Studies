

/* 
 *Metot Anatomisi Nasıldır? Gelin Metot İmzasını İnceleyelim

 Prototip:
   [erişim belirleyici] [geri dönüş değeri] [metodun adı]() => Yandaki kısım metodun imzası diye geçer
  {
 Bu kısım metodun gerçekletireceği operasyonu/fiiliyatı/eylemi/algoritmayı oluşturduğumuz kodladığımız faaliyet alanıdır.
  Bu kısım'da metodun gövdesi diye geçer.
  }


 *ERİŞİM BELİRLEYİCİLERİ:İleri seviyede göreceğimiz Access Modifier yapılardır.Oluşturulmuş olan bir yapının dışarıdan 
 *erişip erişişilemeyeceğini belirlememizi sağlayan komutlardır.
 *ÖRNEĞİN:Public,genel/erişime açık.Private,özel/erişime kapalı gibi komutlar.
 
 
 *Geri Dönüş Değeri(türü):Metotlar yaptıkları operasyonlar,algoritmalar,işlemler neticesinde geriye değerler döndürebilmektedir. 
 *Bu değer kodun içerisinde yakalanabilir ve programatik olarak işlemlere tabi tutulabilir.
 *Geri dönüş değeri ekran çıktısıyla karıştırılmamalıdır.

 *Metot İsmi:Metotlar'da,diğer yapılarda olduğu gibi isimlendirilmektedirler.Bu isimler bizler için bellek adresleri olacaktır
 *ve name conventions (isimlendirme kuralları) geçerlidir.
 
 *NOT:Metot dediğimiz bu yapılanmalar dış dünyadan parametreler alabilmekte ve bu parametrelerde ki bu değerler üzerinde
 *işlemler gerçekleştirebilmektedir.İşte bu parametreleri parantez içerisinden alabilmekteyiz.
 *Bir metot illa ki parametre almak zorunda değildir.Örn (int sayi1) veya (int sayı1,sayı2) . Hiç parametre almayacaksa 
 *eğer () yapmak yeterli olacaktır.
 */

/*
using System;

namespace metotlar
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
*/




/*
 *İşlevine Göre Metot Türleri Nelerdir?
 * () brackets,Metot dediğimiz bu yapılanmalar dışarıdan parametreler alabilmekte ve bu parametreler üzerinde işlemler
 *gerçekleştirebilmektedirler.İşte bu parametreleri parantez içerisinden alabilmektedir.Bir metot illaki parametre almak
 *zorunda değildir.Parametre aldığı durumda ise illaki parametrenin türü belirtilmelidir.
 *ÖRNEĞİN:(int Sayi1), (int Sayi1,Sayi2) gibi.
 
 *{} curly brackets,Metodun gerçekleştireceği operasyonu,fiiliyatı,eylemi yani algoritmayı kodladığımız oluşturduğumuz
 *faaliyet alanıdır.
 
 *Yapılacak işleme göre 4 farklı türde ya da varyasyonda fonksiyon-metot oluşturulabilmektedir.
 *1)Geriye değer döndürmeyen,Parametre almayan
 *2)Geriye değer döndürmeyen,Parametre alan
 *3)Geriye değer döndüren,Parametre almayan
 *4)Geriye değer döndüren,Parametre alan
 

using System;

namespace metotlar
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}*/




/*
 *Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Almayan Metot Türü
  [erişim belirleyici] [geri dönüş değeri] [Metot Adi] (...)
  {
 
  }

 * Bir metot geriye değer döndürmüyorsa programatik karşılığı olarak void ile bildirilmesi zorunludur.Boş bırakılamaz.
 * Bir metot dışardan parametre almayacaksa () yapmamız yeterlidir.
 */

using System;

namespace metotlar
{

    class Program
    {
        static void Main(string[] args)
        {
            Metot1();
        }
        private static void Metot1()
        {
            Console.WriteLine("Geriye Değer döndürmeyen,parametre almayan metot oluşturuldu");
        }
    }
}