//if Yapisi Örnek 1

//Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 Tl'den fazla ise , 2. üründen %25 indirim yaparak ödenecek tutarı
//gösteren uygulamayı yapalım.

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

