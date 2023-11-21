
/*
 * METOD NEDİR?
 *Yazılımda gerçekleştirdiğimiz,fiili olarak gerçekleştirdiğimiz tümm operasyonlar bir metotdur.Metotlara fonksiyonda diyebiliriz.
 *Metot prosedürel programlamanın temel elemanıdır.Bir iş /fiiliyat/operasyon yapan en küçük program parçacıklarıdır.
 *Metot işlem yapamanı sağlayan bir program parçacığıdır.
 *Metorlar sayesinde kodlarımızı yazabiliyoruz,algoritmalarımızı oluşturabiliyoruz.
 *Algoritma,Operasyon-Fiiliyat yapmamamızı sağlayan method.
 *Esasında mimarisel tasarım dışında;özel algoritmalar programlar,program parçacıkları yazarken bir yazılımcının kesinlikle
 *metoda ihtiyacı vardır. 
 *İleri seviyede property denen yapılanmanın içerisinde de herhangi bir algoritma yapılabileceğini göreceğiz. İşte bu 
 *propert'nin de özünde yani compiler seviyesinde bir metot olduğu gerçeğindendir. Aynı şekilde şimdiye kadar içerisinde
 *prosedürel programlamaya dair öğrendiğimiz şeyleri denediğimiz main yapısının da bir metot olduğunu bilmekteyiz.
 */


/* 
 *İşlevsel Açıdan Metot Bize Ne Kazandırır?
 *Metod kodun içerisinde ki tekrarları kaldırmamıza yaramaktadır.
 * Not:Yazılmış olan bir kodu tekrar çağırmakla,tekrar yazmak arasında fark vardır!
 * Not:Metotlar içerisine yazılan kodun,tekrarlı bir şekilde kullanılmasını sağlarlar.Ve bunu yaparken kaynak kodun tekrar
 * etmesinide engellemiş olurlar.Böylece ideal kodlamaya erişmiş oluruz.
 */

using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = new Random().Next();
            }
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}