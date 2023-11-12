//While Döngüsü Kritik yapalım2

//Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım.

int sayi = int.Parse(Console.ReadLine());

while (sayi >= 0)
{
    Console.WriteLine(sayi);
    sayi--;
}