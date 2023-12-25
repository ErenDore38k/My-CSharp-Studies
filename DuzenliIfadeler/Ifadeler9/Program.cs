

using System.Text.RegularExpressions;

string metin = "183A";
Regex regex = new Regex(@"\d{3}[A-E]");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);