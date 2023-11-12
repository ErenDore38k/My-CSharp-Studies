//Manevratik Komutlar - continue Komutu Nedir?

/*Sade ve sadece döngülerden erişilebilen ve döngülerde kullanılabilen bir keyworddür.
*Amaç: Döngüde bir sonraki tura geçilmesini sağlar.Yani bir sonraki periyoda geçiş yapılmasını sağlar.
*/

for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
        continue;
    Console.WriteLine(i);
}