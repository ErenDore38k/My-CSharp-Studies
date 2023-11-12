//Foreach İterasyonu Nasıl Kullanılır?


using System.Collections;

ArrayList sayilar = new ArrayList { 123, 123, 325, 2, 534, 5, 345, 345 };

foreach (object eleman in sayilar)
{
    Console.WriteLine(eleman);
}
// Yukarıdaki örnek Foreach'in proportisini göstermek adına yapılmıştır.
