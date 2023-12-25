
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


