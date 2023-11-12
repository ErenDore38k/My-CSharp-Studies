//Regular Expressions Operatörleri + Operatörü

//Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılan operatördür.
//ÖRNEK: 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade
//oluşturalım.


//^9\d+\s olarak ifade edilir yukarıdaki örnek düzenli ifadelerde.

using System.Text.RegularExpressions;

string metin = "936323535d";
Regex regex = new Regex(@"^9\d+\S");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);