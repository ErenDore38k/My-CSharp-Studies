//Tanımlanmış Diziye Değer Atama

/*İndex numarası dizilere sistem tarafından otomatik verilen ve kimlik mahiyetinde kullanabileceğimiz bir numaradır. Her bir elemana 
 *karşılık gelen unique değerlerdir. Haliyle böyle olamsı demek her bir elemana istediğimiz zaman erişip,değer atama yapabilmemizi yahut
 *var olan değeri okuyabilmemizi sağlayabilmektedir. Dolayısıyla dizilerde tanımlanmış alanlara/elemanlara değer atama yahut değer okuma
 *operasyonlarını indexnumaraları eşliğinde gerçekleştirmekteyiz.
 *Diziye değer koyarken hangi index'e karşılık değer koyacaksa yine indexer operatörüyle bunu bildirmeli ve ilgili değeri atamalıyız.
 *Dizinin içerisinde elemanlara değer atarken değişken davranışı gösterir.Dolayısıyla herhangi bir elemana atanan en sonuncu değer geçerlidir.
 *Dizilerde değer atama ve hatta değer okuma işlemlerinde eğer ki dizinin sınırını aşarsak hata verecektir(Çalışma zamanı hatası).
 *Dizilerde değer ataması yaparken sıralamayı göz önünde tutmak zorunda değiliz..
 *Dizilerde eleman sayısının başta belirlenmesi durumunda , ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamayacağımızdan
 *ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır. 
 */

int[] yaslar = new int[7];
yaslar[3] = 30;
yaslar[2] = 36;
yaslar[0] = 41;
yaslar[5] = 58;

for (int i = 0; i < 7; i++)
{
    Console.WriteLine(yaslar[i]);
}


