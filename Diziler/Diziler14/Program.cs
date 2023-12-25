

Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
Array.Clear(isimler, 0, isimler.Length);
for (int i = 0; i < isimler.Length; i++)
    Console.WriteLine(isimler.GetValue(i));