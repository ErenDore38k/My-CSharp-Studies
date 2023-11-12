//Regular Expressions Operatörleri . Operatörü

//Kullanıldığı yerde \n karakteri dışında herhangi bir karakter bulunabileceğini belirtir.
//\d{3}.A

using System.Text.RegularExpressions;

string metin = "123EA";
Regex regex = new Regex(@"\d{3}.A");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);