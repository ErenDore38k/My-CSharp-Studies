//Regular Expressions Operatörleri |(veya) Operatörü

//Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksal veya | 
//operatörü kullanılabilir.

//ÖRNEK:Baş harfi a ya da b ya da c olan metinsel ifadeyi girelim.
//a|b|c şeklinde yapılır yukarıdaki örneğinin düzenli ifadeler şekli.


using System.Text.RegularExpressions;

string metin = "ali";
Regex regex = new Regex(@"^a|^b|^c");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);