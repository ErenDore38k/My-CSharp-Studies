

Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
int index = Array.IndexOf(isimler, "Rıfkı");
if (index != -1)
{
    Console.WriteLine("Aradığın değer mevcut dizide bulunmaktadır.");
}
