

Array isim = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah", "Cemal", "Ali", "Taner", "Ramazan", "Veysel" };
Array.Sort(isim);
for (int j = 0; j < isim.Length; j++)
    Console.WriteLine(isim.GetValue(j));