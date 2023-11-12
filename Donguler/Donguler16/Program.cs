//While Döngüsü Kritik yapalım3

//0ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yazalım.

int i = 0, toplam = 0;
while (i <= 100)
{
    if (i % 2 == 1)
        toplam += i;
    i++;

}
Console.WriteLine(toplam);

