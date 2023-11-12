//Manevratik Komutlar - goto Komutu Nedir?

/*Kodun senkranzizasyonunu bozup, akışı ters istikamette almamızı sağlayan bir manevratik komuttur.
 *Goto keywordü davramışsal olarak döngülere benzer.
 *switch case yapılanmasında dahili olarak kullanılan bu komut, metot içerisinde her yerde kullanılabilir.
 *Geleneksel codorlar tarafından pek sevilmeyen goto keywordü tavsiye edilmemektedir.
 *Teknik olarak programı yavaşlattığı söylenmektedir. Hatta yapılmış olan perfornans testlerini incelediğimizde bir nebze kayıp ve yavaşlık
 *söz konusudur.Yani maliyeti diğer durumlara nazaran oldukça fazladır.
 *goto keywordüyle senkronizasyonu bozup başa dönme durumu bir döngüyle aynı işlemi yapmaya nazaran daha maliyetli olacaktır..
 *Diller geliştikçe ve yüksek seviyede oldukça bu komutun kalkması doğal bir sürectir.
 */


switch (16)
{
    case 12:
        Console.WriteLine("3*3");
        break;
    case 13:
        Console.WriteLine("2*3");
        break;
    case 16:
        goto case 12;

}