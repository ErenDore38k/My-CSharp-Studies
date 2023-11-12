

Console.WriteLine(2 * 6);
//Bizle çalışan developer bizden 2 ile 5 i çarpmamızı istedi biz ise mantıksal bir hata yaparak 2 ile 6yı çarptık. İşte bu bir mantıksal hata
//örneğidir. Kodumuz kısa olduğu için hemen farkettik.


bool medenihal = true;
if (!medenihal)
{
    Console.WriteLine("Hediye gönder");
}
else
    Console.WriteLine(" Hediye gönderme ");

//Yukarıda ki örnekte biz normalde kişi evliyse hediye gönder değilse gönderme mantığı üzerinden bir örnek yapacaktık. Ama mantıksal bir
// hata ile biz evli değilse hediye gönder evliyse gönderme yaptık işte bu bir mantıksal bir hatadır.