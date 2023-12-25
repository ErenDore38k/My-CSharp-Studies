

using System.Text.RegularExpressions;

string metin = "544-5678179";
Regex regex = new Regex(@"\d{3}-\d{6}");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);