

using System.Text.RegularExpressions;

string metin = "123dır65";
Regex regex = new Regex(@"\d{3}dır\B");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);


