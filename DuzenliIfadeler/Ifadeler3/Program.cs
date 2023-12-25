

using System.Text.RegularExpressions;

string metin = "936323535d";
Regex regex = new Regex(@"^9\d+\S");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);