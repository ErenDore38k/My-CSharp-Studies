

/*
 *Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Almayan Metot Türü
 *Eğer ki bir metot herhangi bir türde geriye değer döndüreceğini belirtiyorsa kesinlikle  o türde bir değer döndürmelidir.
 *Aksi takdirde hata alacaktır.
 *Bu değer döndürme işlemini de önceden de bahsettiğimiz metotlardan çıkış yapmaya,sonlandırmaya yarayan return
 *keyword'ü ile sağlamaktayız.Yani bu keyword sonlandırma işlevinin yanı sıra metot içerisinde de bir değer döndürmektedir.
 *return,nerede işlenirse orada ilgili fonksiyondan/metotdan çıkılır.
 */
using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program başladığında Metot5'i çağır
            char sonuc = Metot5();

            // Sonucu ekrana yazdır
            Console.WriteLine("Metot5'in dönüş değeri: " + sonuc);
        }

        private static char Metot5()
        {
            // 'a' karakterini döndür
            return 'a';
        }
    }
}

/* 
 *Önemli Kritik1
    private int Metot1()
  {
     if (DateTime.Now.Minute > 0)
                return 1;
 } 

*Böyle bir çalışmada return işlemi bir sorgu yapısı içerisinde kullanılırsa,sorgunun doğru olmaması durumunda haliyle bir 
*değer döndürmediği için yine hata alınacaktır.Her türlü durum için geriye değer döndüren fonksiyonlarda-return ile bir değer
*döndürmesi şarttır.
 */

/*
 *Önemli Kritik2
 *Return ile dönecek değerler üzerinde,değeri döndürmeden önce yine türüne uygun işlemlerde yapabilmekteyiz.
 
 public int Metot1()
        { 
            return DateTime.Now.Minute > 30 ? 1 : 0;
        }
 */