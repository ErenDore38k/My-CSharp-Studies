//For Döngüsü Örnek Yapalım1

//1 ile 40 (dahil)arasındaki çift sayıları toplayarak sonucu ekranda gösterelim.

int toplamSonuc = 0;
for (int i = 1; i <= 40; i++)
{
    if (i % 2 == 0)
    {
        toplamSonuc += i;
    }
}
Console.WriteLine("Toplam sonuc " + toplamSonuc);
