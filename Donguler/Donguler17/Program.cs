

int sayi = int.Parse(Console.ReadLine());
int faktoriyel = 1;
while (sayi > 0)
{
    faktoriyel *= sayi;
    sayi--;
}
Console.WriteLine(faktoriyel);

