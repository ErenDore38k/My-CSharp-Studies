//Dizilerin Sınırlılıkları ve Koleksiyon Yapılarının Doğuşu

/*Sınırlılkıklar:Dizilerde tanımlama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
 *Diziler tanımlandığında kullansakda kullanmaksakda bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar. Bu 
 *durumda bellek boyutunda ekstradan maliyete sebep olacağı için bir sınırlılıktır.
 *Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri
 *atayamayacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır.
 *Dizilerde elemanlara değer atarken indexer operatörüyle çok haşır neşir olunmaktadır. Bu durumda bir sınırlılıktır.
*/





//Dizi Tanımlama Varyasyonları - Varyasyon 1

int[] yaslar = new int[3];
yaslar[0] = 36;
yaslar[1] = 25;
yaslar[2] = 69;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(yaslar[i]);
}