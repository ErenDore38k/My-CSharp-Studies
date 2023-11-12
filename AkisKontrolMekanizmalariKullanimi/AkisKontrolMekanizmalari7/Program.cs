
//if Yapısı
/* if yapılanması , elimizdeki bir değerin eşitlik durumuda dahil tümmm karşılaştırmaları( örn olarak büyüktür küçüktür gibi)
 * yapmamızı sağlayan ve sonuca göre akışı yönlendirmemizi sağlayan bir yapılanmadır. ( if yapılanması switch in yapmış olduğu
 * eşitlik durumuna bakma durumunu da yapabilme yeteğine  sahiptir.)
 * Switch Case Elimizdeki bir değerin sadece eşitlik durumunu check eden /kontrol eden kıyaslayan bir akış kontrol mekanizmasıdır.
 * Switch Case de sadece ama sadece eşitlik durumuna bakabiliriz.
 * İf yapısında şart kısmı her daim bool türde olmalidır. Karşılaştırma operatörleri ve mantıksal operatörlerin hepsi burada
 * kullanılabilir. Sebebi ise karşılaştırma ve mantıksal operatörer geriye bool değer döndürdükleri için. 
 * İf yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır. 
 */

bool medenihal = true;
if (medenihal == true)
{
    Console.WriteLine(" Allah mutluluğunuzu daim eylesin ");
}

//Yukarıda ki örnekte durumun sadece doğru true olması üzerine bir örnek verdik durum doğruysa çalışır ve yazılı durum ekrana 
//yazdırılır.değilse kod bloğu sonlanır . 
