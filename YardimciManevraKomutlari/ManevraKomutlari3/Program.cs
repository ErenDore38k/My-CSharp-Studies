//Manevratik Komutlar - break Komutunu Örneklendirelim 2

//Kullanıcıdan alınan sonsuz adet sayı değerlerinden 37'nin katı girildiğinde sonlanan uygulamayı yazalım.

while (true)
{
    Console.WriteLine("Lütfen bir sayı giriniz:");
    int sayı = int.Parse(Console.ReadLine());
    if (sayı % 37 == 0)
    {
        Console.WriteLine("Uygulama sonlanmıştır...");
        break;
    }
}
