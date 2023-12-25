
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
