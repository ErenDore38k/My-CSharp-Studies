
//if Yapısı Üzerine Kritik Yapalım 1

//İf yapılanmasında illa ki else kullanmak zorunda değiliz


int u = 10;
if (u == 10)
{
    Console.WriteLine(" Merhaba yazılım ");
}
Console.WriteLine(" Dünyası");

/*
*Yukarıda ki örnekte ki gibi bir kullanım şekli yapabiliriz. Else kullanmadan . Ama u değeri 10'a eşitse . Eşit değilse 
*ekrana sadece Dünyası yazısı çıktı olarak verilecektir. Nedeni ise Dünyası çıktısının if 'in doğru olma durumuna bağlı olmaması
*sebebiyle. Dünyası çıktısı if e bağlı değil doğruymuş yanlışmış gibi durumlar Dünyası çıktısını ilgilendirmez . 
*Bu örnekte Dünya çıktısı if bloğundan bağımsız hareket etmektedir.
*/