//C#'da Hazır Sınıflar ve Fonksiyonlar Nedir?

/*
 *C# da belirli işlemleri hızlı bir şekilde yapmamızı sağlayan hazır fomksiyonlarımız mevcuttur.
 *Esasen hazır bir yapıya ihtiyaç duymaksızın herhangi bir fonksiyon ortaya koyabiliriz.Tabi burada örneğin
 *bir hazır matematik fonksiyonu için matematik bilgisi bağımlılığı gerekecektir gibi hususlar söz konusu olacaktır.
 */


//Math Sınıfı - Abs Fonksiyonu

//Math Sınıfı: Bu sınıfı kullanabilmek için herhangi bir namespace'i using etmemize gerek yoktur.Varsayılan olarak gelen 
//System namespace'i altında olan bir sınıftır.
//Abs Fonksiyonu
//Absolute Value. Mutlak değer işlemi yapar. 


int a = Math.Abs(-38);
Console.WriteLine(a);
int d = Math.Abs(-200);
Console.WriteLine(d);
int s = Math.Abs(-5 * 3);
Console.WriteLine(s);
int t = Math.Abs(-5 + 3 - 9 * 5);
Console.WriteLine(t);
int o = Math.Abs(-5 * 9 + 10);
Console.WriteLine(o);