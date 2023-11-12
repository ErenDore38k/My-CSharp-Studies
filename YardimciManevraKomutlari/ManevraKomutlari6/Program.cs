//Manevratik Komutlar - continue Komutunu Örneklendirelim 2
//1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdıralım.
for (int i = 1; i <= 1000; i++)
{
    if (i % 7 == 0)
        continue;
    Console.WriteLine(i);
}