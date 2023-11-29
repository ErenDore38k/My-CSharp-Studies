

/*
 *C#'ta ref Keyword'ü Nedir? Ne Amaçla Kullanılmaktadır?
 *Ref keyword'ü referanstan gelmektedir.
 *Referans OOP kavramıdır.
 *OOP'de nesneler(object) RAM'de Heap bölgesinde tutulmaktadır.
 *OOP'de referanslar = operatörü ile iletişime geçebilmektedirler.Bir referans,işaretlediği herhangi bir nesneyi = operatörü sayesinde
 *farkı bir referansa işaretletebilir.
 *Yani,referanslarda = operatörü neticesinde herhangi bir verisel/nesnesel türeme söz konusu olmamakta,işaretlenmiş nesne
 *diğer referans tarafından işaretlenmemektedir.
 *ref keyword'ü değer türlü değişkenlerde referans operasyonları yapmamızı sağlayan bir keyword'dür.
 *ref keyword'ü,değer türlü değişkenlerin referanslarını çağırmamızı/kullanmamızı sağlayan bir keyword'dür.
 *Değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer ref keyword'ü kullanılır.
 *ref keyword'ü değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur.
 *Değer türlü değişkenlerde shallow copy yapmamızı sağlayan bir keyworddür.
 *Ref keyword’ü genellikle metotlarda kullanılır, bu yüzden metotlara has bir anahtar kelime gibi gözükse de görüldüğü gibi
 *istenilen yerde değişkenler üzerinde kullanılabilir. 

 */

/*
//Örnek1
int a = 5;
 ref int b = ref a;
Console.WriteLine(a);
Console.WriteLine(b);

a *= 5;
Console.WriteLine(b);

b -= 10;
Console.WriteLine(a);
*/


//Örnek2

int Y = 10;
X(ref Y);
Console.WriteLine(Y);
void X(ref int a)
{
    a = 25;
}

