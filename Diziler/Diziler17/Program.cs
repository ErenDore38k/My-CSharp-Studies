//Array Sınıfı Reverse Metodu

//Reverse Metodu  elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur.

Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
Array.Reverse(isimler);
for (int i = 0; i < isimler.Length; i++)
    Console.WriteLine(isimler.GetValue(i));