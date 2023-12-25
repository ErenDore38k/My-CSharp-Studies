
int carpım = 1;
while (true)
{
    Console.WriteLine("Lütfen bir sayı giriniz:");
    string girilenDeger = Console.ReadLine();
    if (girilenDeger == "t")
    {
        Console.WriteLine(carpım);
        break;
    }
    else
    {
        int sayı = int.Parse(girilenDeger);
        if (sayı < 0)
            continue;
        carpım *= sayı;

    }

}