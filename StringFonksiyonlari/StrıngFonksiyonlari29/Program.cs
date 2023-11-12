//String Fonksiyonları Örnek -Girilen Metnin İçerisinde Kaç Adet n Karakterinin Geçtiğini Hesaplayalım

Console.WriteLine("Lütfen bir metin giriniz:");
string metin = Console.ReadLine();
int adet = 0;
for (int i = 0; i < metin.Length; i++)
{
    if (metin[i] == 'n')
        adet++;
}
Console.WriteLine(adet);