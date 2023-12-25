

using System.Text.RegularExpressions;

string metin = "9365552gddfhfhfh";
Regex regex = new Regex(@"^9\d\S");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
