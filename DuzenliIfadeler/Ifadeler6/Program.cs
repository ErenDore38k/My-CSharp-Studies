

using System.Text.RegularExpressions;

string metin = "192BA";
Regex regex = new Regex(@"\d{3}B?A");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
