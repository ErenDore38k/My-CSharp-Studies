

Array names = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
string[] names2 = new string[names.Length];
Array.Copy(names, names2, 5);
for (int j = 0; j < names2.Length; j++)
    Console.WriteLine(names2[j]);