//Regular Expressions Operatörleri [n] Operatörleri

//Karakter aralığı belirtir.
//Ayrıca özel karakterlerin yerinde yazılmasınıda ifade eder.
//\d{3}[A-E]

using System.Text.RegularExpressions;

string metin = "183A";
Regex regex = new Regex(@"\d{3}[A-E]");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);