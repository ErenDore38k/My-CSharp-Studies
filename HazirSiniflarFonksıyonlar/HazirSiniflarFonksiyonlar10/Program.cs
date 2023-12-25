

DateTime Tarih1 = new DateTime(2023, 10, 25);
DateTime Tarih2 = new DateTime(2024, 10, 26);
int Result = DateTime.Compare(Tarih1, Tarih2);
if (Result < 0)
{
    Console.WriteLine($"{Tarih1} Küçüktür {Tarih2}.");
}
else if (Result == 0)
{
    Console.WriteLine($"{Tarih1} Esittir {Tarih2}.");
}
else if (Result == 1)
{
    Console.WriteLine($"{Tarih1} Büyüktür {Tarih2}.");
}