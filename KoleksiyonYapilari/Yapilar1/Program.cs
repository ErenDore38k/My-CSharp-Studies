//Koleksiyonlar Nelerdir? Diziler Varken Neden Koleksiyon Yapıları İnşa Edilmiştir?

/*
 *Birden fazla verilerde çalışırken dizilerin daha da gelişmiş bir yapılanmasıdır ve birden fazla koleksiyon mevcuttur.
 *İlki olarakta ArrayList söylenebilir. Koleksiyonları, diziler ile yapabileceğimiz işlemeleri yapmak için kullanmaktayız.
 *Lakin iki yapılanma arasında farklılıklar vardır. Diziler üzerinde de bahsettiğimiz gibi dizilerin sınırlılıkları vardır,
 *bu sınırlılıkları ortadan kaldırmak için neticede koleksiyonlar üretilmiştir gibi bir iddalı anlam yükleyebiliriz.
 *Koleksiyonlar bizzat Object Oriented Programming'in bizlere kazandırdığı belirli yapılanmalardır.Bu sınırlılıklardan kısaca;
 *dizilerde tanımlama yaparken eleman sayısı bildirilmesi zorunludur.Haliyle bu bizler için bir handikap olacaktır.
 *Koleksiyonlarda böyle bir sınırlılık olmayacaktır.Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen 
 *elaman sayısı kadar alan tahsisinde bulunulur.Bu da maliyete,performans kayıplarına sebep olacaktır.
 * Dizilerde doğru bir şekilde çalışılırsa tabi ki de hızlı bir şekilde çalışma yapılabilir.Amma velakin
 * koleksiyonlarda eklenen veri kadar alan tahsisinde bulunulacağından dolayı bu kaygıyı taşımamıza gerek kalmayacaktır.
 * Bir başka sınırlılık olarakta dizilerde eleman sayısının başta belirlenmesi durumunda ihtiyaca binaen daha fazla değer atamak
 * istendiğinde atama yapılamayacak veya aralık genişletilemeyecektir,tekrardan kodları değiştirerek tekrardan derleyerek
 * çözüm odaklı çalışılamayacaktır.Bu da koleksiyonlarda taşımayacağımız bir kaygı olacaktır.
 * Esasen diziler,koleksiyon yapılarına nazaran daha az maliyetlidirler çünkü daha hızlı çalışırlar. Prosedürel olarak
 * programlama diline dahili yapılar olduklarından dolayı. Ancak koleksiyonlarda gelişim sürecine katkılarından dolayı 
 * buradaki maliyeti,efektifçalışmalarımız sayesinde dengelediğini söyleyebiliriz.
 */




//ArrayList Koleksiyonu
/*
 *Daha iyi anlamdırabilmek adına ArrayList koleksiyonumuz için ilk üretilen koleksiyondur ve bu sebepten kendince sınırlıkları
 *da vardır diyebiliriz.
 */




//ArrayList Koleksiyonu Tanımlama

//Diziler tanımlanırken kaç eleman tutacakları bildirilmek zorundadır.
//using System.Collections;

//int[] Yaslarr = new int[17]; // Dizilerde eleman tanımlama 

//ArrayList yaslar = new ArrayList(); // Koleksiyonlarda eleman tanımlama



//ArrayList Tanımlanmış Koleksiyona Değer Atama

/*

using System.Collections;

int[] Yaslarr = new int[17]; // Dizilerde
Yaslarr[5] = 38;             // Dizilerde değer atama yaparken    

ArrayList yaslar = new ArrayList();  // Koleksiyonlarda
yaslar.Add(123);                     // Koleksiyonlarda değer atama yaparken

//Add fonksiyonu kullanılmayan koleksiyonlarda vardır…

*/




//ArrayList Tanımlanmış Koleksiyondan Değer Okuma

using System.Collections;

int[] Yaslarr = new int[17]; // Dizilerde tanımlama yaparken
Yaslarr[5] = 38;             // Dizilerde değer atama yaparken    


ArrayList yaslar = new ArrayList();  // Koleksiyonlarda tanımlama yaparken 
yaslar.Add(123);                     // Koleksiyonlarda değer atama yaparken

for (int i = 0; i < 17; i++)
{
    Yaslarr[i] = i + 10; // Dizilerde
    yaslar.Add(i + 10);  // Koleksiyonlarda 

}
// Dizlerde Değer okuma
Console.WriteLine(Yaslarr[5]);

// Koleksiyonlarda 
Console.WriteLine(yaslar[5]);




