//Mantıksal Hata Durumlarına Örnek 2

bool medenihal = true;
if (!medenihal)
{
    Console.WriteLine("Hediye gönder");
}
else
    Console.WriteLine(" Hediye gönderme ");

/*Yukarıda ki örnekte biz normalde kişi evliyse hediye gönder değilse gönderme mantığı üzerinden bir örnek yapacaktık. Ama mantıksal bir
 *hata ile biz evli değilse hediye gönder evliyse gönderme yaptık işte bu bir mantıksal bir hatadır.
 */

//Çalışma zamanı hataları hata kontrol mekanizmalarında büyük bir öneme/mahiyete/yere sahiptir.
