//Manevratik Komutlar - break Komutunu Örneklendirelim 1

//Kullanıcıdan 't' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yazalım.
int toplam = 0;
while (true)
{
    Console.WriteLine("Lütfen bir sayı giriniz:");
    string girilenDeger = Console.ReadLine();
    if (girilenDeger == "t")
    {
        Console.WriteLine("Toplam Sonuc :" + toplam);
        break;
    }
    else
    {
        toplam += int.Parse(girilenDeger);
    }
}


