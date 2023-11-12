//Regular Expressions Operatörleri {n} Operatörü

//Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli.
//544-5678179
//\d{3}-\d{6}    Böyle bir kullanım yapmak efektif olur ve tercih edilen budur.

using System.Text.RegularExpressions;

string metin = "544-5678179";
Regex regex = new Regex(@"\d{3}-\d{6}");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);