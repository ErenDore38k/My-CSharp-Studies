

using System.Text.RegularExpressions;

string metin = "ali";
Regex regex = new Regex(@"^a|^b|^c");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);