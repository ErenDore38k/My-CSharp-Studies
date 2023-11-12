//Span, ReadOnlySpan, Memory ve ReadOnlyMemory Türleri Nedir? Nasıl Kullanılır?
/*
 *Span Türü Nedir? Bellek üzerinde belirli bir alanı temsil ederek işlemler gerçekleştirmemizi sağlayan bir struct'tır.
 *Bu belirli alanlardan kasıt tabi ki de ardışık alan kapsayan Array değerleridir.
 *Normal şartlarda Array'lerin belleğin Heap kısmında tutulduğunu biliyoruz. Lakin stackalloc keyword'ü sayesinde Stackte'de
 *Array tanımlayabilmekteyiz.
 *Span,stack yahut heap farketmeksizin tanımlanmış olan Array'lerin tümünü yahut bir bölümünü bizler için refere edebilen ve
 *üzerinde işlemler gerçekleştirmemizi sağlayan kullanışlı bir yapıdır.
 *Span,dizi ve string gibi maliyetli veriler üzerinde yapılacak operasyonlarda performans açısından yüksek getiriyle birlikte
 *maliyeti olabildiğince düşürmekte ve ekstradan değer kopyalamaya gerek kalmaksızın tüm faaliyetleri gerçekleştirmemize 
 *olanak sağlamaktadır.
 * 
 *ReadOnlySpan<T> : Span niteliklerinin tümünü sağlamakta lakin adı üzerinde sadece okunabilir kılmaktadır.
 * 
 *Span ile ArraySegment & StringSegment Farkı nedir? : 
 *ArraySegment sadece string ve dizilerde temsiliyet yapabiliyorken, Span bellek üzerinde olan herhangi bir yeri temsil edebilir.
 *ArraySegment'te referans edilen alana hertürlü müdahale edilebilirken, ReadOnlySpan'da bu verisel operasyonlar engellenebilir
 *ve sadece okunabilir bir davranış sergilenebilir.
 *Sadece string yahut array türler ile çalışılacaksa eğer ArraySegment ve StringSegment tavsiye edilir.
 * 
 *Memory Türü nedir? 
 *Span ref struct olarak tasarlanmış bir struct'tır.
 *Dolayısıyla heap'te allocation(tahsis) edilememe ,object ,dynamic yahut interface türleri aracılığıyla referans edilememe 
 *yahut bir class içerisinde field veya property olarak tanımlanamama gibi kısıtlamaları vardır.
 *Memory türü Span'ın bu kısıtlamalarından münezzeh versiyonudur.
 *ReadOnlyMemory : Memory türünün sadece okunabilir halidir.
 */


//Span Türünü Pratikte İnceleyelim
int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
Span<int> span = new Span<int>(sayilar);
Span<int> span2 = sayilar;
Span<int> span3 = new Span<int>(sayilar, 3, 5);
Span<int> span4 = sayilar.AsSpan();
Span<int> span5 = sayilar.AsSpan(3, 5);

string metin = "Sen kalbimde batan güneş , ben yollarda çilekeş..";
ReadOnlySpan<char> readOnlySpan = metin.AsSpan();
Console.WriteLine(readOnlySpan.ToString());