//(C# 8.0)Ranges and Indices Özelliği

/*Ranges and Indices Özelliği: C# 8.0 ile veri kaynakları üzerinde gerekli manipülasyasyonu sağlayabilmek ve bunun yanında 
 *kaynak içerisindeki tüm veriler üzerinde yapılan genel sorgulamalar ve algoritmalardan kaçınmak , yani direkt olarak 
 *hedef veriler odaklı çalışabilmek için yeni tipler ile operatörler geliştirilmiş bulunmaktadır.
 *Veri kümleri üzerinde yapabildiğimiz işlemleri daha spesifik bir şekilde gerçekleştirmemizi sağlayan özelliklerdir.
 */


//(C# 8.0)Ranges and Indices - System.Index Türü

//Not ^ Bu operatör şöyle yapılmaktadır : shift + 3 + space
/* System.Index Türü: Dizi ve koleksiyon yapılarındaki index kavramının tip olarak belirlenmiş halidir.
 * Temelde index değerini bir tür ile tutmakla beraber ^ operatörüyle birlikte daha fazla anlam ifade etmekte ve dizinin index
 *değerlerini tersine ifade edecek şekilde bir sorumlukuk yüklenmektedir.
 *index i = ^3;  3 2 1 olmakla beraber 3 ü ifade etmektedir.
 *^ operatörü ile tersine index durumları kullanılırken index değerinin 0'dan değil 1 den başladığına dikkat ediniz.
 *indexer [] operatörü içerisinde tam sayı verebildiği gibi index türüde verebilir.
 */


//(C# 8.0)Ranges and Indices - System.Index Türü İnceleme

int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Index index = 5; // Soldan alma 0 dan başlar (n-1) e kadar.
Console.WriteLine(sayilar[index]);

// ^ bu operatör Index e özeldir. 