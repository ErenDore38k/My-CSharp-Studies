//Regular Expressions Match Sınıfı Özellikleri

using System.Text.RegularExpressions;

string Metin = "(544) 567 8179";
Regex regex = new Regex(@"[()]\d{3}[)]\s\d{3}\s\d{4}");
Match Matc = regex.Match(Metin);
Console.WriteLine($"Success: {Matc.Success}");
Console.WriteLine($"Value: {Matc.Value}");
Console.WriteLine($"Index: {Matc.Index}");
Console.WriteLine($"Length: {Matc.Length}");