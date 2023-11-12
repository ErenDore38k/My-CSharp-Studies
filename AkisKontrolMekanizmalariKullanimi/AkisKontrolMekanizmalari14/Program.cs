//if Else if Yapısı Üzerine Kritik Yapalım 1

int sayı = int.Parse(Console.ReadLine());
if (sayı > 100 && sayı <= 200)
{
    Console.WriteLine(" 100 ile 200 arasında");
}
if (sayı > 200 && sayı <= 300)
{
    Console.WriteLine(" 200 ile 300 arasında");
}
if (sayı > 200 && sayı <= 400)
{
    Console.WriteLine(" 200 ile 400 arasında");
}

//Yukarıda ki örnekte birden fazla durumun doğru veya girdiğimiz sayının birden fazla durumu kapsamasını örnek verdik. Bu örneği
//doğru,mantıksal bir hataya sebebiyet vermemek içinde if yazarak kullanma yaptık. 205 sayısını girdiğimizde hem 200 ile
//300 arasında hemde 200 ile 400 arasında yazdıraca ekrana. 