//Manevratik Komutlar - return Komutu Nedir?

/*Her yerde(metot içerisinde) kullanılabilir erişilebilir bir keyworddür.
 *İki işlevi görmektedir : 
 *1) Nerede çağrılıyorsa çağrılsın bulunduğu metottan çıkış yapar. Yani metodu sonlandırır.
 *2) İleride göreceğimiz metotlar konusunda geriye değer döndürme sorumluluğunuda üstlenen bir keyworddür.
 *Returnden sonra hangi komut geliyorsa gelsin metot sonlanacağı için İşlenmeyecektir.
 */



//Manevratik Komutlar - return Komutunu Örneklendirelim

//Kullanıcı 'c' tuşuna basana kadar sonsuz döngüde dönen uygulamayı yazınız..

while (true)
{
    if (Console.ReadKey().KeyChar == 'c')
    {
        Console.WriteLine("Uygulama Sona ermiştir...");
        return;
    }
    Console.WriteLine("");
    Console.WriteLine("Uygulama çalışıyor");
}
