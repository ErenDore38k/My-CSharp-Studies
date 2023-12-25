

Console.Write(" Lütfen birinci ürünün fiyatını giriniz : ");
int birinciUrununFiyatı = int.Parse(Console.ReadLine());
Console.Write(" Lütfen ikinci ürünün fiyatını giriniz :");
int ikinciUrununFiyatı = int.Parse(Console.ReadLine());

if (birinciUrununFiyatı + ikinciUrununFiyatı > 200)
{
    int toplamSonTutar = birinciUrununFiyatı + (ikinciUrununFiyatı * 75 / 100);
    Console.WriteLine(toplamSonTutar);
}
else
{
    Console.WriteLine(birinciUrununFiyatı + ikinciUrununFiyatı);
}

