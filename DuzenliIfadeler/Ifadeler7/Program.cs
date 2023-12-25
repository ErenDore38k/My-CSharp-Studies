

using System.Text.RegularExpressions;

string metin = "123EA";
Regex regex = new Regex(@"\d{3}.A");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);