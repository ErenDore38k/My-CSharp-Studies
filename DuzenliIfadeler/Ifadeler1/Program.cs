

using System.Text.RegularExpressions;

string metin = "123456velinaci";
Regex regex = new Regex("^1");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
