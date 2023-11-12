//Regular Expressions Operatörleri ? Operatörü

//Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.
//\d{3}B?A örnek olarak 234BA olabilir veya 543BA veya 543A olabilir olmayan örnek mesala 132BBA gibi örnekler olmaz.

using System.Text.RegularExpressions;

string metin = "192BA";
Regex regex = new Regex(@"\d{3}B?A");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
